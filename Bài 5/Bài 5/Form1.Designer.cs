namespace Bài_5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlControl = new System.Windows.Forms.Panel();
            btnPause = new System.Windows.Forms.Button();
            btnStart = new System.Windows.Forms.Button();
            pnlPrice = new System.Windows.Forms.Panel();
            lblBTCPrice = new System.Windows.Forms.Label();
            lblBTCTitle = new System.Windows.Forms.Label();
            dgvHistoryLog = new System.Windows.Forms.DataGridView();
            colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTrend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            lblLastUpdate = new System.Windows.Forms.ToolStripStatusLabel();
            lblSyncCount = new System.Windows.Forms.ToolStripStatusLabel();
            pnlControl.SuspendLayout();
            pnlPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistoryLog).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlControl
            // 
            pnlControl.Controls.Add(btnPause);
            pnlControl.Controls.Add(btnStart);
            pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
            pnlControl.Location = new System.Drawing.Point(0, 0);
            pnlControl.Name = "pnlControl";
            pnlControl.Size = new System.Drawing.Size(760, 60);
            pnlControl.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.Location = new System.Drawing.Point(15, 12);
            btnStart.Name = "btnStart";
            btnStart.Size = new System.Drawing.Size(170, 38);
            btnStart.TabIndex = 0;
            btnStart.Text = "Bắt đầu Giám sát";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnPause
            // 
            btnPause.Enabled = false;
            btnPause.Location = new System.Drawing.Point(200, 12);
            btnPause.Name = "btnPause";
            btnPause.Size = new System.Drawing.Size(130, 38);
            btnPause.TabIndex = 1;
            btnPause.Text = "Tạm dừng";
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // pnlPrice
            // 
            pnlPrice.Controls.Add(lblBTCPrice);
            pnlPrice.Controls.Add(lblBTCTitle);
            pnlPrice.Dock = System.Windows.Forms.DockStyle.Top;
            pnlPrice.Location = new System.Drawing.Point(0, 60);
            pnlPrice.Name = "pnlPrice";
            pnlPrice.Size = new System.Drawing.Size(760, 100);
            pnlPrice.TabIndex = 1;
            // 
            // lblBTCTitle
            // 
            lblBTCTitle.AutoSize = true;
            lblBTCTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            lblBTCTitle.Location = new System.Drawing.Point(15, 10);
            lblBTCTitle.Name = "lblBTCTitle";
            lblBTCTitle.Size = new System.Drawing.Size(150, 23);
            lblBTCTitle.TabIndex = 0;
            lblBTCTitle.Text = "Tỷ giá BTC/USD";
            // 
            // lblBTCPrice
            // 
            lblBTCPrice.AutoSize = true;
            lblBTCPrice.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            lblBTCPrice.Location = new System.Drawing.Point(12, 35);
            lblBTCPrice.Name = "lblBTCPrice";
            lblBTCPrice.Size = new System.Drawing.Size(100, 62);
            lblBTCPrice.TabIndex = 1;
            lblBTCPrice.Text = "---";
            // 
            // dgvHistoryLog
            // 
            dgvHistoryLog.AllowUserToAddRows = false;
            dgvHistoryLog.AllowUserToDeleteRows = false;
            dgvHistoryLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistoryLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistoryLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colTime, colPrice, colChange, colPercent, colTrend });
            dgvHistoryLog.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvHistoryLog.Location = new System.Drawing.Point(0, 160);
            dgvHistoryLog.Name = "dgvHistoryLog";
            dgvHistoryLog.ReadOnly = true;
            dgvHistoryLog.RowHeadersWidth = 51;
            dgvHistoryLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvHistoryLog.Size = new System.Drawing.Size(760, 244);
            dgvHistoryLog.TabIndex = 2;
            // 
            // colTime
            // 
            colTime.HeaderText = "Thời gian";
            colTime.MinimumWidth = 6;
            colTime.Name = "colTime";
            colTime.ReadOnly = true;
            // 
            // colPrice
            // 
            colPrice.HeaderText = "Giá BTC/USD";
            colPrice.MinimumWidth = 6;
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            // 
            // colChange
            // 
            colChange.HeaderText = "Biến động";
            colChange.MinimumWidth = 6;
            colChange.Name = "colChange";
            colChange.ReadOnly = true;
            // 
            // colPercent
            // 
            colPercent.HeaderText = "Tỷ lệ (%)";
            colPercent.MinimumWidth = 6;
            colPercent.Name = "colPercent";
            colPercent.ReadOnly = true;
            // 
            // colTrend
            // 
            colTrend.HeaderText = "Xu hướng";
            colTrend.MinimumWidth = 6;
            colTrend.Name = "colTrend";
            colTrend.ReadOnly = true;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { lblLastUpdate, lblSyncCount });
            statusStrip1.Location = new System.Drawing.Point(0, 404);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(760, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblLastUpdate
            // 
            lblLastUpdate.Name = "lblLastUpdate";
            lblLastUpdate.Size = new System.Drawing.Size(200, 20);
            lblLastUpdate.Text = "Cập nhật cuối: --:--:--";
            // 
            // lblSyncCount
            // 
            lblSyncCount.Name = "lblSyncCount";
            lblSyncCount.Size = new System.Drawing.Size(200, 20);
            lblSyncCount.Text = "Số lượt đồng bộ: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(760, 430);
            Controls.Add(dgvHistoryLog);
            Controls.Add(pnlPrice);
            Controls.Add(pnlControl);
            Controls.Add(statusStrip1);
            MinimumSize = new System.Drawing.Size(600, 400);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Giám sát Tỷ giá Tài chính Thời gian thực";
            FormClosing += Form1_FormClosing;
            pnlControl.ResumeLayout(false);
            pnlPrice.ResumeLayout(false);
            pnlPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistoryLog).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Panel pnlPrice;
        private System.Windows.Forms.Label lblBTCTitle;
        private System.Windows.Forms.Label lblBTCPrice;
        private System.Windows.Forms.DataGridView dgvHistoryLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChange;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrend;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblLastUpdate;
        private System.Windows.Forms.ToolStripStatusLabel lblSyncCount;
    }
}