namespace Bài_2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.sepFile = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.sepTool1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.sepTool2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblSearch = new System.Windows.Forms.ToolStripLabel();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLoadCover = new System.Windows.Forms.Button();
            this.picBookCover = new System.Windows.Forms.PictureBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.lblGia = new System.Windows.Forms.Label();
            this.txtTheLoai = new System.Windows.Forms.TextBox();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lblMa = new System.Windows.Forms.Label();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.colMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnhBia = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBookCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();

            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuFile, this.mnuEdit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 0;

            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuOpen, this.mnuSave, this.sepFile, this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Text = "File";
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Text = "Mở file CSV...";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Text = "Lưu file CSV...";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            this.sepFile.Name = "sepFile";
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Text = "Thoát";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);

            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuAddMenu, this.mnuDelete, this.mnuSearch});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Text = "Edit";
            this.mnuAddMenu.Name = "mnuAddMenu";
            this.mnuAddMenu.Text = "Thêm";
            this.mnuAddMenu.Click += new System.EventHandler(this.btnThem_Click);
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.Text = "Xóa";
            this.mnuDelete.Click += new System.EventHandler(this.mnuDelete_Click);
            this.mnuSearch.Name = "mnuSearch";
            this.mnuSearch.Text = "Tìm kiếm...";
            this.mnuSearch.Click += new System.EventHandler(this.tsbSearch_Click);

            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tsbOpen, this.tsbSave, this.sepTool1, this.tsbAdd, this.tsbEdit, this.sepTool2, this.lblSearch, this.txtSearch, this.tsbSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1200, 27);
            this.toolStrip1.TabIndex = 1;

            this.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Text = "Mở file";
            this.tsbOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Text = "Lưu file";
            this.tsbSave.Click += new System.EventHandler(this.mnuSave_Click);
            this.sepTool1.Name = "sepTool1";
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Text = "Thêm mới";
            this.tsbAdd.Click += new System.EventHandler(this.btnThem_Click);
            this.tsbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Text = "Sửa";
            this.tsbEdit.Click += new System.EventHandler(this.btnCapNhat_Click);
            this.sepTool2.Name = "sepTool2";
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Text = "Tìm:";
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(150, 27);
            this.tsbSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Text = "Tìm kiếm";
            this.tsbSearch.Click += new System.EventHandler(this.tsbSearch_Click);

            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.lblCount, this.lblTotal, this.lblTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 728);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1200, 22);
            this.statusStrip1.TabIndex = 2;
            this.lblCount.Name = "lblCount";
            this.lblCount.Text = "Tổng số đầu sách: 0";
            this.lblCount.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Text = "Tổng giá trị: 0 VNĐ";
            this.lblTotal.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblTime.Name = "lblTime";
            this.lblTime.Spring = true;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.panelLeft.AutoScroll = true;
            this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeft.Controls.Add(this.btnCapNhat);
            this.panelLeft.Controls.Add(this.btnThem);
            this.panelLeft.Controls.Add(this.btnLoadCover);
            this.panelLeft.Controls.Add(this.picBookCover);
            this.panelLeft.Controls.Add(this.txtSoLuong);
            this.panelLeft.Controls.Add(this.lblSoLuong);
            this.panelLeft.Controls.Add(this.txtGia);
            this.panelLeft.Controls.Add(this.lblGia);
            this.panelLeft.Controls.Add(this.txtTheLoai);
            this.panelLeft.Controls.Add(this.lblTheLoai);
            this.panelLeft.Controls.Add(this.txtTacGia);
            this.panelLeft.Controls.Add(this.lblTacGia);
            this.panelLeft.Controls.Add(this.txtTen);
            this.panelLeft.Controls.Add(this.lblTen);
            this.panelLeft.Controls.Add(this.txtMa);
            this.panelLeft.Controls.Add(this.lblMa);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 51);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(360, 677);
            this.panelLeft.TabIndex = 3;

            int x = 15;
            int w = 320;
            int y = 15;

            this.lblMa.AutoSize = false;
            this.lblMa.Location = new System.Drawing.Point(x, y);
            this.lblMa.Size = new System.Drawing.Size(w, 24);
            this.lblMa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMa.Text = "Mã sách";
            this.txtMa.Location = new System.Drawing.Point(x, y + 26);
            this.txtMa.Size = new System.Drawing.Size(w, 23);
            y += 65;

            this.lblTen.AutoSize = false;
            this.lblTen.Location = new System.Drawing.Point(x, y);
            this.lblTen.Size = new System.Drawing.Size(w, 24);
            this.lblTen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTen.Text = "Tên sách";
            this.txtTen.Location = new System.Drawing.Point(x, y + 26);
            this.txtTen.Size = new System.Drawing.Size(w, 23);
            y += 65;

            this.lblTacGia.AutoSize = false;
            this.lblTacGia.Location = new System.Drawing.Point(x, y);
            this.lblTacGia.Size = new System.Drawing.Size(w, 24);
            this.lblTacGia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTacGia.Text = "Tác giả";
            this.txtTacGia.Location = new System.Drawing.Point(x, y + 26);
            this.txtTacGia.Size = new System.Drawing.Size(w, 23);
            y += 65;

            this.lblTheLoai.AutoSize = false;
            this.lblTheLoai.Location = new System.Drawing.Point(x, y);
            this.lblTheLoai.Size = new System.Drawing.Size(w, 24);
            this.lblTheLoai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTheLoai.Text = "Thể loại";
            this.txtTheLoai.Location = new System.Drawing.Point(x, y + 26);
            this.txtTheLoai.Size = new System.Drawing.Size(w, 23);
            y += 65;

            this.lblGia.AutoSize = false;
            this.lblGia.Location = new System.Drawing.Point(x, y);
            this.lblGia.Size = new System.Drawing.Size(w, 24);
            this.lblGia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGia.Text = "Giá bán (VNĐ)";
            this.txtGia.Location = new System.Drawing.Point(x, y + 26);
            this.txtGia.Size = new System.Drawing.Size(w, 23);
            y += 65;

            this.lblSoLuong.AutoSize = false;
            this.lblSoLuong.Location = new System.Drawing.Point(x, y);
            this.lblSoLuong.Size = new System.Drawing.Size(w, 24);
            this.lblSoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSoLuong.Text = "Số lượng";
            this.txtSoLuong.Location = new System.Drawing.Point(x, y + 26);
            this.txtSoLuong.Size = new System.Drawing.Size(w, 23);
            y += 65;

            this.picBookCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBookCover.Location = new System.Drawing.Point(x, y);
            this.picBookCover.Size = new System.Drawing.Size(w, 200);
            this.picBookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            y += 210;

            this.btnLoadCover.Location = new System.Drawing.Point(x, y);
            this.btnLoadCover.Size = new System.Drawing.Size(w, 30);
            this.btnLoadCover.Text = "Tải ảnh bìa";
            this.btnLoadCover.Click += new System.EventHandler(this.btnLoadCover_Click);
            y += 40;

            this.btnThem.Location = new System.Drawing.Point(x, y);
            this.btnThem.Size = new System.Drawing.Size(150, 35);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.btnCapNhat.Location = new System.Drawing.Point(x + 170, y);
            this.btnCapNhat.Size = new System.Drawing.Size(150, 35);
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);

            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.AutoGenerateColumns = false;
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvBooks.ColumnHeadersHeight = 30;
            this.dgvBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBooks.Location = new System.Drawing.Point(360, 51);
            this.dgvBooks.MultiSelect = false;
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.RowHeadersVisible = false;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(840, 677);
            this.dgvBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellClick);

            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colMa, this.colTen, this.colTacGia, this.colTheLoai, this.colGia, this.colSoLuong, this.colAnhBia});

            this.colMa.DataPropertyName = "MaSach";
            this.colMa.HeaderText = "Mã sách";
            this.colMa.Name = "colMa";
            this.colTen.DataPropertyName = "TenSach";
            this.colTen.HeaderText = "Tên sách";
            this.colTen.Name = "colTen";
            this.colTacGia.DataPropertyName = "TacGia";
            this.colTacGia.HeaderText = "Tác giả";
            this.colTacGia.Name = "colTacGia";
            this.colTheLoai.DataPropertyName = "TheLoai";
            this.colTheLoai.HeaderText = "Thể loại";
            this.colTheLoai.Name = "colTheLoai";
            this.colGia.DataPropertyName = "GiaBan";
            this.colGia.HeaderText = "Giá";
            this.colGia.Name = "colGia";
            this.colGia.DefaultCellStyle.Format = "N0";
            this.colSoLuong.DataPropertyName = "SoLuong";
            this.colSoLuong.HeaderText = "SL";
            this.colSoLuong.Name = "colSoLuong";
            this.colAnhBia.DataPropertyName = "AnhBia";
            this.colAnhBia.HeaderText = "Ảnh bìa";
            this.colAnhBia.Name = "colAnhBia";

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tài Liệu Sách - Nhà Sách";

            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBookCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile, mnuOpen, mnuSave, mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit, mnuAddMenu, mnuDelete, mnuSearch;
        private System.Windows.Forms.ToolStripSeparator sepFile;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbOpen, tsbSave, tsbAdd, tsbEdit, tsbSearch;
        private System.Windows.Forms.ToolStripSeparator sepTool1, sepTool2;
        private System.Windows.Forms.ToolStripLabel lblSearch;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblCount, lblTotal, lblTime;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.PictureBox picBookCover;
        private System.Windows.Forms.Button btnLoadCover, btnThem, btnCapNhat;
        private System.Windows.Forms.Label lblMa, lblTen, lblTacGia, lblTheLoai, lblGia, lblSoLuong;
        private System.Windows.Forms.TextBox txtMa, txtTen, txtTacGia, txtTheLoai, txtGia, txtSoLuong;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa, colTen, colTacGia, colTheLoai, colGia, colSoLuong, colAnhBia;
    }
}