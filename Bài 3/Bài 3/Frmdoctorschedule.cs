using System;
using System.Data;
using System.Windows.Forms;

namespace Bài_3
{
    public partial class frmDoctorSchedule : Form
    {
        public frmDoctorSchedule()
        {
            InitializeComponent();
        }

        private void frmDoctorSchedule_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Mã BS", typeof(string));
            table.Columns.Add("Họ và tên", typeof(string));
            table.Columns.Add("Khoa/Phòng", typeof(string));
            table.Columns.Add("Ngày trực", typeof(string));
            table.Columns.Add("Ca trực", typeof(string));
            table.Columns.Add("Phòng trực", typeof(string));

            table.Rows.Add("BS001", "Nguyễn Văn An", "Nội tổng quát", "19/10/2026", "Sáng (07:00 - 12:00)", "P.101");
            table.Rows.Add("BS002", "Trần Thị Bích", "Sản", "19/10/2026", "Chiều (13:00 - 17:00)", "P.205");
            table.Rows.Add("BS003", "Lê Quốc Cường", "Tim mạch", "20/10/2026", "Đêm (19:00 - 07:00)", "P.310");
            table.Rows.Add("BS004", "Phạm Thị Dung", "Nhi", "20/10/2026", "Sáng (07:00 - 12:00)", "P.112");
            table.Rows.Add("BS005", "Vũ Đức Hải", "Ngoại chấn thương", "21/10/2026", "Chiều (13:00 - 17:00)", "P.402");
            table.Rows.Add("BS006", "Đặng Thị Hương", "Da liễu", "22/10/2026", "Sáng (07:00 - 12:00)", "P.118");

            dgvSchedule.DataSource = table;
        }
    }
}