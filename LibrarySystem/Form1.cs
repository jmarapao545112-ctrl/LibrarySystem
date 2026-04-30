using LibrarySystem.Models;

namespace LibrarySystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private async void btnProcessCheckout_Click(object sender, EventArgs e)
        {
            try
            {
                btnProcessCheckout.Enabled = false;
                lblStatus.Text = "Updating Database...";

                // 1. Database logic (Critical path)
                await Task.Delay(1000);

                // 2. Email logic (Non-blocking background task)
                await RunEmailSimulationAsync();

                // 3. Update Log
                string timestamp = DateTime.Now.ToLongTimeString();
                var logItem = new ListViewItem(timestamp);
                logItem.SubItems.Add("Checkout");
                logItem.SubItems.Add("Book 101 Checked Out Successfully");
                lvActivityLog.Items.Insert(0, logItem);

                lblStatus.Text = "Success!";
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error occurred.";
                MessageBox.Show($"Failed to process checkout: {ex.Message}");
            }
            finally
            {
                btnProcessCheckout.Enabled = true;
            }
        }

        private async Task RunEmailSimulationAsync()
        {
            lblStatus.Text = "Sending Email Notification...";
            prgEmail.Value = 0;
            for (int i = 0; i <= 100; i += 10)
            {
                await Task.Delay(300);
                prgEmail.Value = i;
            }
        }

        private BookRepository _repo = new BookRepository();

        private async void Form1_Load(object sender, EventArgs e)
        {
            cmbMemberType.SelectedIndex = 0; // Select Student by default
            await RefreshGrid();
        }

        private async Task RefreshGrid()
        {
            var books = await _repo.GetAllBooksAsync();

            // Flatten the data so it displays nicely in the grid
            dgvBooks.DataSource = books.Select(b => new
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

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string term = txtSearch.Text;
            if (term.Length > 2 || term.Length == 0)
            {
                // Search after 3 letters or if cleared
                var results = await _repo.SearchBooksAsync(term);
                dgvBooks.DataSource = results.Select(b => new
                {
                    b.Id,
                    b.Title,
                    b.Isbn,
                    b.Status,
                    b.Quantity
                }).ToList();
            }
        }
    }
}