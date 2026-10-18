using System;
using System.Data;
using System.Windows.Forms;

namespace Bài_3
{
    public partial class frmPatientProfiles : Form
    {
        public frmPatientProfiles()
        {
            InitializeComponent();
        }

        private void frmPatientProfiles_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Mã BN", typeof(string));
            table.Columns.Add("Họ và tên", typeof(string));
            table.Columns.Add("Ngày sinh", typeof(string));
            table.Columns.Add("Giới tính", typeof(string));
            table.Columns.Add("Địa chỉ", typeof(string));
            table.Columns.Add("Khoa điều trị", typeof(string));
            table.Columns.Add("Chẩn đoán", typeof(string));

            table.Rows.Add("BN001", "Trần Văn Bình", "12/03/1985", "Nam", "Hà Nội", "Nội tổng quát", "Viêm dạ dày");
            table.Rows.Add("BN002", "Lê Thị Hoa", "25/07/1992", "Nữ", "Hải Phòng", "Sản", "Theo dõi thai kỳ");
            table.Rows.Add("BN003", "Phạm Minh Tuấn", "03/11/1978", "Nam", "Nam Định", "Tim mạch", "Tăng huyết áp");
            table.Rows.Add("BN004", "Nguyễn Thị Lan", "30/01/2001", "Nữ", "Bắc Ninh", "Da liễu", "Viêm da cơ địa");
            table.Rows.Add("BN005", "Hoàng Văn Nam", "18/09/1965", "Nam", "Thái Bình", "Ngoại chấn thương", "Gãy xương cẳng tay");
            table.Rows.Add("BN006", "Đỗ Thị Mai", "09/05/1990", "Nữ", "Hà Nam", "Nhi", "Viêm phổi");

            dgvPatients.DataSource = table;
        }
    }
}