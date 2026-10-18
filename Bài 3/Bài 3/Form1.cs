using System;
using System.Windows.Forms;

namespace Bài_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenSingleChild<T>() where T : Form, new()
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is T)
                {
                    if (child.WindowState == FormWindowState.Minimized)
                    {
                        child.WindowState = FormWindowState.Normal;
                    }
                    child.Activate();
                    return;
                }
            }

            T frm = new T();
            frm.MdiParent = this;
            frm.Show();
        }

        private void CloseAllChildren()
        {
            Form[] children = this.MdiChildren;
            foreach (Form child in children)
            {
                child.Close();
            }
        }

        private void mnuHoSoBenhNhan_Click(object sender, EventArgs e)
        {
            OpenSingleChild<frmPatientProfiles>();
        }

        private void mnuDanhMucBacSi_Click(object sender, EventArgs e)
        {
            OpenSingleChild<frmDoctorSchedule>();
        }

        private void mnuDanhMucKhoaPhong_Click(object sender, EventArgs e)
        {
            OpenSingleChild<frmDoctorSchedule>();
        }

        private void mnuCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuTileHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuTileVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuDongTatCa_Click(object sender, EventArgs e)
        {
            CloseAllChildren();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Đăng xuất",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                CloseAllChildren();
                Application.Restart();
            }
        }

        private void mnuNapLai_Click(object sender, EventArgs e)
        {
            if (tmrProgress.Enabled)
            {
                return;
            }
            progressBar.Value = 0;
            lblTrangThai.Text = "Đang nạp lại dữ liệu...";
            mnuNapLai.Enabled = false;
            tmrProgress.Start();
        }

        private void tmrProgress_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < progressBar.Maximum)
            {
                progressBar.Value = Math.Min(progressBar.Value + 5, progressBar.Maximum);
                return;
            }

            tmrProgress.Stop();

            foreach (Form child in this.MdiChildren)
            {
                if (child is frmPatientProfiles patientForm)
                {
                    patientForm.LoadData();
                }
                else if (child is frmDoctorSchedule doctorForm)
                {
                    doctorForm.LoadData();
                }
            }

            progressBar.Value = 0;
            mnuNapLai.Enabled = true;
            lblTrangThai.Text = "Nạp dữ liệu hoàn tất";
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                lblTrangThai.Text = "Đang mở: " + this.ActiveMdiChild.Text;
            }
            else
            {
                lblTrangThai.Text = "Sẵn sàng";
            }
        }
    }
}