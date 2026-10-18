using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_5
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource cts;
        private decimal lastPrice = 65000m;
        private int syncCount = 0;
        private const int MaxLogRows = 200;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;

            btnStart.Enabled = false;
            btnPause.Enabled = true;

            Task.Run(() => MonitorLoop(token));
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            StopMonitoring();
            btnStart.Enabled = true;
            btnPause.Enabled = false;
        }

        private void StopMonitoring()
        {
            if (cts != null)
            {
                cts.Cancel();
                cts.Dispose();
                cts = null;
            }
        }

        private async Task MonitorLoop(CancellationToken token)
        {
            Random random = new Random();

            while (!token.IsCancellationRequested)
            {
                decimal change = Math.Round((decimal)(random.NextDouble() * 400 - 200), 2);
                decimal oldPrice = lastPrice;
                decimal newPrice = Math.Max(1000m, oldPrice + change);
                lastPrice = newPrice;

                UpdateTicker(oldPrice, newPrice, DateTime.Now);

                try
                {
                    await Task.Delay(2000, token);
                }
                catch (OperationCanceledException)
                {
                    break;
                }
            }
        }

        private void UpdateTicker(decimal oldPrice, decimal newPrice, DateTime time)
        {
            if (this.InvokeRequired)
            {
                try
                {
                    this.Invoke(new Action(() => UpdateTicker(oldPrice, newPrice, time)));
                }
                catch (ObjectDisposedException)
                {
                }
                catch (InvalidOperationException)
                {
                }
                return;
            }

            decimal diff = newPrice - oldPrice;
            decimal percent = oldPrice == 0 ? 0 : diff / oldPrice * 100;

            Color color;
            string trend;
            if (diff > 0)
            {
                color = Color.Green;
                trend = "Tăng ▲";
            }
            else if (diff < 0)
            {
                color = Color.Red;
                trend = "Giảm ▼";
            }
            else
            {
                color = Color.DimGray;
                trend = "Đi ngang";
            }

            lblBTCPrice.Text = newPrice.ToString("N2") + " USD";
            lblBTCPrice.ForeColor = color;

            int index = dgvHistoryLog.Rows.Add(
                time.ToString("HH:mm:ss"),
                newPrice.ToString("N2"),
                diff.ToString("+#,##0.00;-#,##0.00;0.00"),
                percent.ToString("+0.000;-0.000;0.000"),
                trend);
            dgvHistoryLog.Rows[index].DefaultCellStyle.ForeColor = color;

            if (dgvHistoryLog.Rows.Count > MaxLogRows)
            {
                dgvHistoryLog.Rows.RemoveAt(0);
            }
            dgvHistoryLog.FirstDisplayedScrollingRowIndex = dgvHistoryLog.Rows.Count - 1;

            syncCount++;
            lblLastUpdate.Text = "Cập nhật cuối: " + time.ToString("HH:mm:ss");
            lblSyncCount.Text = "Số lượt đồng bộ: " + syncCount;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopMonitoring();
        }
    }
}