using LibrarySystem.Models;
using System;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LibrarySystem
{
    // Part 3.6: Delegate definition
    public delegate void CheckoutEventHandler(object sender, int bookId);

    public partial class Form1 : Form
    {
        private BookRepository _repo = new BookRepository();

        // Part 3.5: Thread Safety lock
        private static SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1);

        // Part 3.6: Event definition
        public event CheckoutEventHandler OnBookCheckedOut;

        public Form1()
        {
            InitializeComponent();
            // Subscribe to event (Requirement 6)
            this.OnBookCheckedOut += (s, id) =>
            {
                Console.WriteLine($"NotificationService: Book {id} has been processed.");
            };
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // Setup UI defaults
            cmbMemberType.Items.Clear();
            cmbMemberType.Items.AddRange(new string[] { "Student", "Faculty", "Guest" });
            cmbMemberType.SelectedIndex = 0;

            // Fixes "0 references" by actually calling the methods
            await SeedData();
            await RefreshGrid();
        }

        private async Task RefreshGrid()
        {
            var books = await _repo.GetAllBooksAsync();

            // Part 4.2: Using a LINQ "Where" clause to clean up the logic
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
            await _semaphore.WaitAsync(); // Part 3.5: Thread Safety
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

                // --- THE MISSING PART: Actually update the database (Part 3.1) ---
                using (var db = new LibraryContext())
                {
                    var book = await db.Books.FindAsync(bookId);
                    if (book == null || book.Quantity <= 0)
                    {
                        lblStatus.Text = "Error: Out of stock!";
                        return;
                    }

                    book.Quantity -= 1; // Decrease stock
                    await db.SaveChangesAsync(); // Save to DB
                }
                // ------------------------------------------------------------------

                await RunEmailSimulationAsync(); // Part 3.2 & 3.4

                // Part 3.3: Log to file
                string logEntry = $"{DateTime.Now}: Book {bookId} Checked Out\n";
                File.AppendAllText("log.txt", logEntry);

                // Part 3.6: Trigger the Event
                OnBookCheckedOut?.Invoke(this, bookId);

                UpdateActivityLog($"Success: {txtCheckoutTitle.Text} checked out.");
                lblStatus.Text = "Success!";

                await RefreshGrid(); // Update the UI to show the new quantity!
                txtQuantity.Text = (int.Parse(txtQuantity.Text) - 1).ToString();
                //txtCheckoutBookId.Clear();
                //txtCheckoutTitle.Clear();
                //txtQuantity.Clear();
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
                await Task.Delay(600); // Total ~3 seconds
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
                // --- ADD THESE TWO LINES TO FORCE A RESET ---
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
                // --------------------------------------------

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

            // We only search if the user has typed 3 or more letters, 
            // or if they cleared the box (to show all books again).
            if (term.Length > 0 || term.Length == 0)
            {
                var results = await _repo.SearchBooksAsync(term);

                // Use the same logic as RefreshGrid to display the results
                dgvBooks.DataSource = results.Where(b => b.IsProcessable).Select(b => new
                {
                    b.Id,
                    b.Title,
                    b.Isbn,
                    Authors = string.Join(", ", b.Authors.Select(a => a.Name)), // <--- FIX THIS LINE
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

                // ADD THIS LINE (Make sure the name matches your 3rd textbox):
                txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
            }
        }

        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new LibraryContext())
                {
                    // 1. Create a default author (or you could add a textbox for this too!)
                    var author = new Author { Name = "Unknown Author" };

                    // 2. Build the new book using the data from your textboxes
                    var newBook = new Book
                    {
                        Title = txtNewTitle.Text,
                        Isbn = txtNewIsbn.Text,
                        Year = int.Parse(txtNewYear.Text),
                        Quantity = int.Parse(txtNewQuantity.Text),
                        Status = "Available", // Default status
                        IsReference = false   // Default to false so it shows up in your filtered grid
                    };

                    // Link the author and the book
                    newBook.Authors.Add(author);

                    // 3. Add to the EF Core database tracking
                    db.Books.Add(newBook);

                    // 4. Save changes to the actual SQL database
                    await db.SaveChangesAsync();
                }

                // 5. Clear the textboxes so they are empty for the next entry
                txtNewTitle.Clear();
                txtNewIsbn.Clear();
                txtNewYear.Clear();
                txtNewQuantity.Clear();

                // 6. Refresh the grid so the new book appears instantly!
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