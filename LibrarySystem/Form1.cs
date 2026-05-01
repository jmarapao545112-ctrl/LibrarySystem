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
                btnProcessCheckout.Enabled = false;
                lblStatus.Text = "Updating Database...";

                // 1. Database Logic (Requirement 3.1)
                await Task.Delay(1000);

                // 2. Async Email Simulation (Requirement 3.2 & 3.4)
                await RunEmailSimulationAsync();

                // 3. Log to file (Requirement 3.3)
                File.AppendAllText("log.txt", $"{DateTime.Now}: Book 101 Checked Out\n");

                // 4. Trigger Event (Requirement 3.6)
                OnBookCheckedOut?.Invoke(this, 101);

                UpdateActivityLog("Book 101 Checked Out Successfully");
                lblStatus.Text = "Success!";
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error occurred.";
                MessageBox.Show(ex.Message);
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
                if (!db.Books.Any())
                {
                    var author = new Author { Name = "C# Expert" };
                    var book = new Book { Title = "EF Core Guide", Isbn = "123-456", Quantity = 5, Status = "Available", Year = 2024 };
                    book.Authors.Add(author);
                    db.Books.Add(book);
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
            if (term.Length > 2 || term.Length == 0)
            {
                var results = await _repo.SearchBooksAsync(term);

                // Use the same logic as RefreshGrid to display the results
                dgvBooks.DataSource = results.Where(b => b.IsProcessable).Select(b => new
                {
                    b.Id,
                    b.Title,
                    b.Isbn,
                    b.Status,
                    b.Quantity
                }).ToList();
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }
    }
}