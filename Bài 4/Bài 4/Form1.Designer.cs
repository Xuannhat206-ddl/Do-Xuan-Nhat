namespace Bài_4
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
            grpCriteria = new System.Windows.Forms.GroupBox();
            lblNote = new System.Windows.Forms.Label();
            txtNote = new System.Windows.Forms.TextBox();
            btnCancel = new System.Windows.Forms.Button();
            btnStatistic = new System.Windows.Forms.Button();
            cboBranch = new System.Windows.Forms.ComboBox();
            lblBranch = new System.Windows.Forms.Label();
            dtpTo = new System.Windows.Forms.DateTimePicker();
            lblTo = new System.Windows.Forms.Label();
            dtpFrom = new System.Windows.Forms.DateTimePicker();
            lblFrom = new System.Windows.Forms.Label();
            pnlStatus = new System.Windows.Forms.Panel();
            lblProcessingStatus = new System.Windows.Forms.Label();
            pgbLoading = new System.Windows.Forms.ProgressBar();
            dgvRevenueData = new System.Windows.Forms.DataGridView();
            grpCriteria.SuspendLayout();
            pnlStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRevenueData).BeginInit();
            SuspendLayout();
            // 
            // grpCriteria
            // 
            grpCriteria.Controls.Add(lblNote);
            grpCriteria.Controls.Add(txtNote);
            grpCriteria.Controls.Add(btnCancel);
            grpCriteria.Controls.Add(btnStatistic);
            grpCriteria.Controls.Add(cboBranch);
            grpCriteria.Controls.Add(lblBranch);
            grpCriteria.Controls.Add(dtpTo);
            grpCriteria.Controls.Add(lblTo);
            grpCriteria.Controls.Add(dtpFrom);
            grpCriteria.Controls.Add(lblFrom);
            grpCriteria.Dock = System.Windows.Forms.DockStyle.Top;
            grpCriteria.Location = new System.Drawing.Point(0, 0);
            grpCriteria.Name = "grpCriteria";
            grpCriteria.Size = new System.Drawing.Size(900, 130);
            grpCriteria.TabIndex = 0;
            grpCriteria.TabStop = false;
            grpCriteria.Text = "Tiêu chí thống kê";
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Location = new System.Drawing.Point(20, 33);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new System.Drawing.Size(66, 20);
            lblFrom.TabIndex = 0;
            lblFrom.Text = "Từ ngày:";
            // 
            // dtpFrom
            // 
            dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpFrom.Location = new System.Drawing.Point(100, 28);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new System.Drawing.Size(130, 27);
            dtpFrom.TabIndex = 1;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Location = new System.Drawing.Point(255, 33);
            lblTo.Name = "lblTo";
            lblTo.Size = new System.Drawing.Size(76, 20);
            lblTo.TabIndex = 2;
            lblTo.Text = "Đến ngày:";
            // 
            // dtpTo
            // 
            dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpTo.Location = new System.Drawing.Point(340, 28);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new System.Drawing.Size(130, 27);
            dtpTo.TabIndex = 3;
            // 
            // lblBranch
            // 
            lblBranch.AutoSize = true;
            lblBranch.Location = new System.Drawing.Point(495, 33);
            lblBranch.Name = "lblBranch";
            lblBranch.Size = new System.Drawing.Size(73, 20);
            lblBranch.TabIndex = 4;
            lblBranch.Text = "Chi nhánh:";
            // 
            // cboBranch
            // 
            cboBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboBranch.FormattingEnabled = true;
            cboBranch.Items.AddRange(new object[] { "Tất cả chi nhánh", "Hà Nội", "TP. Hồ Chí Minh", "Đà Nẵng", "Cần Thơ" });
            cboBranch.Location = new System.Drawing.Point(580, 28);
            cboBranch.Name = "cboBranch";
            cboBranch.Size = new System.Drawing.Size(200, 28);
            cboBranch.TabIndex = 5;
            // 
            // btnStatistic
            // 
            btnStatistic.Location = new System.Drawing.Point(20, 75);
            btnStatistic.Name = "btnStatistic";
            btnStatistic.Size = new System.Drawing.Size(170, 36);
            btnStatistic.TabIndex = 6;
            btnStatistic.Text = "Thống Kê Doanh Thu";
            btnStatistic.UseVisualStyleBackColor = true;
            btnStatistic.Click += btnStatistic_Click;
            // 
            // btnCancel
            // 
            btnCancel.Enabled = false;
            btnCancel.Location = new System.Drawing.Point(205, 75);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(140, 36);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Hủy Thao Tác";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Location = new System.Drawing.Point(370, 83);
            lblNote.Name = "lblNote";
            lblNote.Size = new System.Drawing.Size(66, 20);
            lblNote.TabIndex = 8;
            lblNote.Text = "Ghi chú:";
            // 
            // txtNote
            // 
            txtNote.Location = new System.Drawing.Point(445, 80);
            txtNote.Name = "txtNote";
            txtNote.Size = new System.Drawing.Size(335, 27);
            txtNote.TabIndex = 9;
            // 
            // pnlStatus
            // 
            pnlStatus.Controls.Add(lblProcessingStatus);
            pnlStatus.Controls.Add(pgbLoading);
            pnlStatus.Dock = System.Windows.Forms.DockStyle.Top;
            pnlStatus.Location = new System.Drawing.Point(0, 130);
            pnlStatus.Name = "pnlStatus";
            pnlStatus.Size = new System.Drawing.Size(900, 60);
            pnlStatus.TabIndex = 1;
            // 
            // pgbLoading
            // 
            pgbLoading.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pgbLoading.Location = new System.Drawing.Point(12, 8);
            pgbLoading.Name = "pgbLoading";
            pgbLoading.Size = new System.Drawing.Size(876, 22);
            pgbLoading.TabIndex = 0;
            // 
            // lblProcessingStatus
            // 
            lblProcessingStatus.AutoSize = true;
            lblProcessingStatus.Location = new System.Drawing.Point(12, 34);
            lblProcessingStatus.Name = "lblProcessingStatus";
            lblProcessingStatus.Size = new System.Drawing.Size(60, 20);
            lblProcessingStatus.TabIndex = 1;
            lblProcessingStatus.Text = "Sẵn sàng";
            // 
            // dgvRevenueData
            // 
            dgvRevenueData.AllowUserToAddRows = false;
            dgvRevenueData.AllowUserToDeleteRows = false;
            dgvRevenueData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvRevenueData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRevenueData.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvRevenueData.Location = new System.Drawing.Point(0, 190);
            dgvRevenueData.Name = "dgvRevenueData";
            dgvRevenueData.ReadOnly = true;
            dgvRevenueData.RowHeadersWidth = 51;
            dgvRevenueData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvRevenueData.Size = new System.Drawing.Size(900, 410);
            dgvRevenueData.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(900, 600);
            Controls.Add(dgvRevenueData);
            Controls.Add(pnlStatus);
            Controls.Add(grpCriteria);
            MinimumSize = new System.Drawing.Size(820, 400);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Bảng điều khiển Thống kê Doanh thu";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            grpCriteria.ResumeLayout(false);
            grpCriteria.PerformLayout();
            pnlStatus.ResumeLayout(false);
            pnlStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRevenueData).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox grpCriteria;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.ComboBox cboBranch;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.ProgressBar pgbLoading;
        private System.Windows.Forms.Label lblProcessingStatus;
        private System.Windows.Forms.DataGridView dgvRevenueData;
    }
}