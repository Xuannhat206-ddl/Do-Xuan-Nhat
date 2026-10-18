using System;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_4
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource cts;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpTo.Value = DateTime.Today;
            dtpFrom.Value = DateTime.Today.AddDays(-30);
            cboBranch.SelectedIndex = 0;
        }

        private void SetRunning(bool running)
        {
            btnStatistic.Enabled = !running;
            btnCancel.Enabled = running;
            dtpFrom.Enabled = !running;
            dtpTo.Enabled = !running;
            cboBranch.Enabled = !running;
        }

        private async void btnStatistic_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dtpFrom.Value.Date;
            DateTime toDate = dtpTo.Value.Date;
            string branch = cboBranch.Text;

            if (toDate < fromDate)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CancellationTokenSource source = new CancellationTokenSource();
            cts = source;

            SetRunning(true);
            dgvRevenueData.DataSource = null;
            pgbLoading.Value = 0;
            lblProcessingStatus.Text = "Đang khởi tạo truy vấn...";

            IProgress<int> progress = new Progress<int>(value =>
            {
                pgbLoading.Value = value;
                lblProcessingStatus.Text = "Đang xử lý dữ liệu... " + value + "%";
            });

            try
            {
                DataTable result = await Task.Run(() => QueryRevenue(fromDate, toDate, branch, progress, source.Token), source.Token);

                dgvRevenueData.DataSource = result;
                dgvRevenueData.Columns["Số tiền (VNĐ)"].DefaultCellStyle.Format = "N0";
                dgvRevenueData.Columns["Số tiền (VNĐ)"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                decimal total = 0;
                foreach (DataRow row in result.Rows)
                {
                    total += (decimal)row["Số tiền (VNĐ)"];
                }

                pgbLoading.Value = 100;
                lblProcessingStatus.Text = "Hoàn tất: " + result.Rows.Count + " giao dịch - Tổng doanh thu: " + total.ToString("N0") + " VNĐ";
            }
            catch (OperationCanceledException)
            {
                if (IsDisposed)
                {
                    return;
                }
                pgbLoading.Value = 0;
                lblProcessingStatus.Text = "Đã hủy thao tác!";
                MessageBox.Show("Đã hủy thao tác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                source.Dispose();
                cts = null;
                SetRunning(false);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (cts != null)
            {
                btnCancel.Enabled = false;
                cts.Cancel();
            }
        }

        private DataTable QueryRevenue(DateTime fromDate, DateTime toDate, string branch, IProgress<int> progress, CancellationToken token)
        {
            Random random = new Random();
            int totalMilliseconds = random.Next(4000, 6001);
            int steps = 100;
            int delay = totalMilliseconds / steps;

            for (int i = 1; i <= steps; i++)
            {
                token.ThrowIfCancellationRequested();
                Thread.Sleep(delay);
                progress.Report(i);
            }

            token.ThrowIfCancellationRequested();

            string[] branches = { "Hà Nội", "TP. Hồ Chí Minh", "Đà Nẵng", "Cần Thơ" };
            string[] customers = { "Nguyễn Văn An", "Trần Thị Bình", "Lê Quốc Cường", "Phạm Thị Dung", "Hoàng Minh Đức", "Vũ Thị Hà", "Đặng Văn Hùng", "Bùi Thị Lan" };
            string[] services = { "Khám tổng quát", "Xét nghiệm máu", "Siêu âm", "Chụp X-quang", "Nội soi", "Điều trị ngoại trú", "Gói tầm soát" };

            DataTable table = new DataTable();
            table.Columns.Add("Mã GD", typeof(string));
            table.Columns.Add("Ngày giao dịch", typeof(string));
            table.Columns.Add("Chi nhánh", typeof(string));
            table.Columns.Add("Khách hàng", typeof(string));
            table.Columns.Add("Dịch vụ", typeof(string));
            table.Columns.Add("Số tiền (VNĐ)", typeof(decimal));

            int days = (toDate - fromDate).Days + 1;
            int rowCount = Math.Min(Math.Max(days * 8, 50), 1000);

            for (int i = 1; i <= rowCount; i++)
            {
                token.ThrowIfCancellationRequested();

                string rowBranch = branch == "Tất cả chi nhánh" ? branches[random.Next(branches.Length)] : branch;
                DateTime date = fromDate.AddDays(random.Next(days));
                decimal amount = random.Next(20, 500) * 10000m;

                table.Rows.Add("GD" + i.ToString("D5"), date.ToString("dd/MM/yyyy"), rowBranch,
                    customers[random.Next(customers.Length)], services[random.Next(services.Length)], amount);
            }

            return table;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cts != null)
            {
                cts.Cancel();
            }
        }
    }
}