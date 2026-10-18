namespace Bài_3
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            mnuNapLai = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            mnuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            mnuHoSoBenhNhan = new System.Windows.Forms.ToolStripMenuItem();
            mnuDanhMucBacSi = new System.Windows.Forms.ToolStripMenuItem();
            mnuDanhMucKhoaPhong = new System.Windows.Forms.ToolStripMenuItem();
            mnuCuaSo = new System.Windows.Forms.ToolStripMenuItem();
            mnuCascade = new System.Windows.Forms.ToolStripMenuItem();
            mnuTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            mnuTileVertical = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            mnuDongTatCa = new System.Windows.Forms.ToolStripMenuItem();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            lblBacSiTruc = new System.Windows.Forms.ToolStripStatusLabel();
            lblTrangThai = new System.Windows.Forms.ToolStripStatusLabel();
            progressBar = new System.Windows.Forms.ToolStripProgressBar();
            tmrProgress = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            //
            // menuStrip1
            //
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuHeThong, mnuQuanLy, mnuCuaSo });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1000, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            //
            // mnuHeThong
            //
            mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuDangXuat, mnuNapLai, toolStripSeparator1, mnuThoat });
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Size = new System.Drawing.Size(85, 24);
            mnuHeThong.Text = "Hệ thống";
            //
            // mnuDangXuat
            //
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Size = new System.Drawing.Size(224, 26);
            mnuDangXuat.Text = "Đăng xuất";
            mnuDangXuat.Click += mnuDangXuat_Click;
            //
            // mnuNapLai
            //
            mnuNapLai.Name = "mnuNapLai";
            mnuNapLai.ShortcutKeys = System.Windows.Forms.Keys.F5;
            mnuNapLai.Size = new System.Drawing.Size(224, 26);
            mnuNapLai.Text = "Nạp lại dữ liệu";
            mnuNapLai.Click += mnuNapLai_Click;
            //
            // toolStripSeparator1
            //
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            //
            // mnuThoat
            //
            mnuThoat.Name = "mnuThoat";
            mnuThoat.ShortcutKeys = System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4;
            mnuThoat.Size = new System.Drawing.Size(224, 26);
            mnuThoat.Text = "Thoát";
            mnuThoat.Click += mnuThoat_Click;
            //
            // mnuQuanLy
            //
            mnuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuHoSoBenhNhan, mnuDanhMucBacSi, mnuDanhMucKhoaPhong });
            mnuQuanLy.Name = "mnuQuanLy";
            mnuQuanLy.Size = new System.Drawing.Size(70, 24);
            mnuQuanLy.Text = "Quản lý";
            //
            // mnuHoSoBenhNhan
            //
            mnuHoSoBenhNhan.Name = "mnuHoSoBenhNhan";
            mnuHoSoBenhNhan.Size = new System.Drawing.Size(250, 26);
            mnuHoSoBenhNhan.Text = "Hồ sơ Bệnh nhân";
            mnuHoSoBenhNhan.Click += mnuHoSoBenhNhan_Click;
            //
            // mnuDanhMucBacSi
            //
            mnuDanhMucBacSi.Name = "mnuDanhMucBacSi";
            mnuDanhMucBacSi.Size = new System.Drawing.Size(250, 26);
            mnuDanhMucBacSi.Text = "Danh mục Bác sĩ";
            mnuDanhMucBacSi.Click += mnuDanhMucBacSi_Click;
            //
            // mnuDanhMucKhoaPhong
            //
            mnuDanhMucKhoaPhong.Name = "mnuDanhMucKhoaPhong";
            mnuDanhMucKhoaPhong.Size = new System.Drawing.Size(250, 26);
            mnuDanhMucKhoaPhong.Text = "Danh mục Khoa/Phòng";
            mnuDanhMucKhoaPhong.Click += mnuDanhMucKhoaPhong_Click;
            //
            // mnuCuaSo
            //
            mnuCuaSo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuCascade, mnuTileHorizontal, mnuTileVertical, toolStripSeparator2, mnuDongTatCa });
            mnuCuaSo.Name = "mnuCuaSo";
            mnuCuaSo.Size = new System.Drawing.Size(70, 24);
            mnuCuaSo.Text = "Cửa sổ";
            //
            // mnuCascade
            //
            mnuCascade.Name = "mnuCascade";
            mnuCascade.Size = new System.Drawing.Size(250, 26);
            mnuCascade.Text = "Xếp tầng (Cascade)";
            mnuCascade.Click += mnuCascade_Click;
            //
            // mnuTileHorizontal
            //
            mnuTileHorizontal.Name = "mnuTileHorizontal";
            mnuTileHorizontal.Size = new System.Drawing.Size(250, 26);
            mnuTileHorizontal.Text = "Ngang (Tile Horizontal)";
            mnuTileHorizontal.Click += mnuTileHorizontal_Click;
            //
            // mnuTileVertical
            //
            mnuTileVertical.Name = "mnuTileVertical";
            mnuTileVertical.Size = new System.Drawing.Size(250, 26);
            mnuTileVertical.Text = "Dọc (Tile Vertical)";
            mnuTileVertical.Click += mnuTileVertical_Click;
            //
            // toolStripSeparator2
            //
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(247, 6);
            //
            // mnuDongTatCa
            //
            mnuDongTatCa.Name = "mnuDongTatCa";
            mnuDongTatCa.Size = new System.Drawing.Size(250, 26);
            mnuDongTatCa.Text = "Đóng tất cả";
            mnuDongTatCa.Click += mnuDongTatCa_Click;
            //
            // statusStrip1
            //
            statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { lblBacSiTruc, lblTrangThai, progressBar });
            statusStrip1.Location = new System.Drawing.Point(0, 575);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(1000, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            //
            // lblBacSiTruc
            //
            lblBacSiTruc.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            lblBacSiTruc.Name = "lblBacSiTruc";
            lblBacSiTruc.Size = new System.Drawing.Size(250, 20);
            lblBacSiTruc.Text = "Bác sĩ trực: BS. Nguyễn Văn An";
            //
            // lblTrangThai
            //
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new System.Drawing.Size(600, 20);
            lblTrangThai.Spring = true;
            lblTrangThai.Text = "Sẵn sàng";
            lblTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // progressBar
            //
            progressBar.Name = "progressBar";
            progressBar.Size = new System.Drawing.Size(150, 18);
            //
            // tmrProgress
            //
            tmrProgress.Interval = 40;
            tmrProgress.Tick += tmrProgress_Tick;
            //
            // Form1
            //
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1000, 601);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Hệ thống Quản lý Bệnh viện & Truy xuất Hồ sơ Bệnh án";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            MdiChildActivate += Form1_MdiChildActivate;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuNapLai;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem mnuHoSoBenhNhan;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMucBacSi;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMucKhoaPhong;
        private System.Windows.Forms.ToolStripMenuItem mnuCuaSo;
        private System.Windows.Forms.ToolStripMenuItem mnuCascade;
        private System.Windows.Forms.ToolStripMenuItem mnuTileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem mnuTileVertical;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuDongTatCa;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblBacSiTruc;
        private System.Windows.Forms.ToolStripStatusLabel lblTrangThai;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.Timer tmrProgress;
    }
}
