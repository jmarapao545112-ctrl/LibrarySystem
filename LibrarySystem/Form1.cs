using LibrarySystem.Models;
using System;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace LibrarySystem
{
    public delegate void CheckoutEventHandler(object sender, int bookId);

    public partial class Form1 : Form
    {
        private BookRepository _repo = new BookRepository();

        private static SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1);

        public event CheckoutEventHandler OnBookCheckedOut;

        public Form1()
        {
            InitializeComponent();
            
            this.OnBookCheckedOut += (s, id) =>
            {
                Console.WriteLine($"NotificationService: Book {id} has been processed.");
            };
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            
            cmbMemberType.Items.Clear();
            cmbMemberType.Items.AddRange(new string[] { "Student", "Faculty", "Guest" });
            cmbMemberType.SelectedIndex = 0;

            await SeedData();
            await RefreshGrid();
        }

        private async Task RefreshGrid()
        {
            var books = await _repo.GetAllBooksAsync();

            var displayList = books.Where(b => b.Status == "Available" && !b.IsReference && b.Year > 2000)
            .Select(b => new
            {
                b.Id,
                b.Title,
                b.Isbn,
                Authors = string.Join(", ", b.Authors.Select(a => a.Name)),
                b.Status,
                b.IsReference,
                b.Year,
                b.Quantity
            }).ToList();

            dgvBooks.DataSource = displayList;
        }

        private async void btnProcessCheckout_Click(object sender, EventArgs e)
        {
            await _semaphore.WaitAsync(); 
            try
            {
                if (string.IsNullOrEmpty(txtCheckoutBookId.Text))
                {
                    MessageBox.Show("Please select a book first!");
                    return;
                }

                btnProcessCheckout.Enabled = false;
                lblStatus.Text = "Processing Checkout...";
                int bookId = int.Parse(txtCheckoutBookId.Text);

                using (var db = new LibraryContext())
                {
                    var book = await db.Books.FindAsync(bookId);
                    if (book == null || book.Quantity <= 0)
                    {
                        lblStatus.Text = "Error: Out of stock!";
                        return;
                    }

                    book.Quantity -= 1; 
                    await db.SaveChangesAsync(); 
                }
              
                await RunEmailSimulationAsync();

                string logEntry = $"{DateTime.Now}: Book {bookId} Checked Out\n";
                File.AppendAllText("log.txt", logEntry);

                OnBookCheckedOut?.Invoke(this, bookId);

                UpdateActivityLog($"Success: {txtCheckoutTitle.Text} checked out.");
                lblStatus.Text = "Success!";

                await RefreshGrid();
                txtQuantity.Text = (int.Parse(txtQuantity.Text) - 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                _semaphore.Release();
                btnProcessCheckout.Enabled = true;
            }
        }

        private async Task RunEmailSimulationAsync()
        {
            lblStatus.Text = "Sending Email...";
            prgEmail.Value = 0;
            for (int i = 0; i <= 100; i += 20)
            {
                await Task.Delay(600); 
                prgEmail.Value = i;
            }
        }

        private void UpdateActivityLog(string message)
        {
            var logItem = new ListViewItem(DateTime.Now.ToLongTimeString());
            logItem.SubItems.Add("Checkout");
            logItem.SubItems.Add(message);
            lvActivityLog.Items.Insert(0, logItem);
        }

        private async Task SeedData()
        {
            using (var db = new LibraryContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
               
                if (!db.Books.Any())
                {
                    var author = new Author { Name = "C# Expert" };

                    var book1 = new Book { Title = "EF Core Guide", Isbn = "123-456", Quantity = 20, Status = "Available", Year = 2024 };
                    book1.Authors.Add(author);

                    db.Books.AddRange(book1);
                    await db.SaveChangesAsync();
                }
            }
        }

        private void btnCalculateFee_Click(object sender, EventArgs e)
        {
            if (cmbMemberType.SelectedItem == null) return;

            int days = (int)numDaysLate.Value;

            ILateFeeStrategy strategy = cmbMemberType.SelectedItem.ToString() == "Student"
              ? new StudentFeeStrategy()
              : new FacultyFeeStrategy();

            var member = new Member(strategy);
            decimal fee = member.GetFee(days);

            lblFeeResult.Text = $"Total Fee: {fee:C} ({cmbMemberType.SelectedItem} - {days} days)";
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string term = txtSearch.Text;

            if (term.Length > 0 || term.Length == 0)
            {
                var results = await _repo.SearchBooksAsync(term);

                dgvBooks.DataSource = results.Where(b => b.IsProcessable).Select(b => new
                {
                    b.Id,
                    b.Title,
                    b.Isbn,
                    Authors = string.Join(", ", b.Authors.Select(a => a.Name)),
                    b.Status,
                    b.IsReference,
                    b.Year,
                    b.Quantity
                }).ToList();
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                var row = dgvBooks.Rows[e.RowIndex];
                txtCheckoutBookId.Text = row.Cells["Id"].Value.ToString();
                txtCheckoutTitle.Text = row.Cells["Title"].Value.ToString();

                txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
            }
        }

        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new LibraryContext())
                {
                    var newBook = new Book
                    {
                        Title = txtNewTitle.Text,
                        Isbn = txtNewIsbn.Text,
                        Year = int.Parse(txtNewYear.Text),
                        Quantity = int.Parse(txtNewQuantity.Text),
                        Status = "Available", 
                        IsReference = false   
                    };

                    string authorName = txtNewAuthor.Text.Trim();
                    if (!string.IsNullOrEmpty(authorName))
                    {
                        var existingAuthor = db.Authors.FirstOrDefault(a => a.Name == authorName);

                        if (existingAuthor != null)
                        {
                            newBook.Authors.Add(existingAuthor);
                        }
                        else
                        {
                            var newAuthor = new Author { Name = authorName };
                            newBook.Authors.Add(newAuthor);
                        }
                    }

                    db.Books.Add(newBook);
                    await db.SaveChangesAsync();
                }

                txtNewTitle.Clear();
                txtNewIsbn.Clear();
                txtNewYear.Clear();
                txtNewQuantity.Clear();
                txtNewAuthor.Clear();

                await RefreshGrid();

                MessageBox.Show("Book added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding book. Make sure Year and Quantity are numbers! Details: " + ex.Message);
            }
        }

    }
}