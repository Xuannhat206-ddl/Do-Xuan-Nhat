using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Bài_1
{
    public partial class Form1 : Form
    {
        private BindingList<MemberModel> members;
        private BindingSource bs;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            members = new BindingList<MemberModel>();
            bs = new BindingSource();
            bs.DataSource = members;

            SetupGrid();
            dgvMembers.DataSource = bs;

            SetupBindings();
            AttachClearErrorHandlers();
            ClearForm();
        }

        private void SetupGrid()
        {
            dgvMembers.AutoGenerateColumns = false;
            dgvMembers.Columns.Clear();

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colMemberId",
                HeaderText = "Mã HV",
                DataPropertyName = "MemberId",
                FillWeight = 12
            });

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colFullName",
                HeaderText = "Tên hội viên",
                DataPropertyName = "FullName",
                FillWeight = 25
            });

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPhone",
                HeaderText = "SĐT",
                DataPropertyName = "Phone",
                FillWeight = 15
            });

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPackage",
                HeaderText = "Gói tập",
                DataPropertyName = "Package",
                FillWeight = 15
            });

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colStartDate",
                HeaderText = "Ngày ĐK",
                DataPropertyName = "StartDate",
                FillWeight = 15,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colFee",
                HeaderText = "Phí dịch vụ",
                DataPropertyName = "Fee",
                FillWeight = 18,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N0",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });
        }

        private void SetupBindings()
        {
            txtMemberId.DataBindings.Add("Text", bs, "MemberId", true, DataSourceUpdateMode.Never);
            txtFullName.DataBindings.Add("Text", bs, "FullName", true, DataSourceUpdateMode.Never);
            txtPhone.DataBindings.Add("Text", bs, "Phone", true, DataSourceUpdateMode.Never);
            cboPackage.DataBindings.Add("SelectedItem", bs, "Package", true, DataSourceUpdateMode.Never);
            dtpStartDate.DataBindings.Add("Value", bs, "StartDate", true, DataSourceUpdateMode.Never);
            txtFee.DataBindings.Add("Text", bs, "Fee", true, DataSourceUpdateMode.Never);
        }

        private void AttachClearErrorHandlers()
        {
            txtFullName.TextChanged += (s, e) => errorProvider1.SetError(txtFullName, "");
            txtPhone.TextChanged += (s, e) => errorProvider1.SetError(txtPhone, "");
            txtFee.TextChanged += (s, e) => errorProvider1.SetError(txtFee, "");
        }

        private void ClearForm()
        {
            bs.Position = -1;
            txtMemberId.Text = GenerateNextId();
            txtFullName.Clear();
            txtPhone.Clear();
            cboPackage.SelectedIndex = 0;
            dtpStartDate.Value = DateTime.Now;
            txtFee.Clear();
            errorProvider1.Clear();
        }

        private string GenerateNextId()
        {
            int max = 0;
            foreach (var m in members)
            {
                if (m.MemberId != null && m.MemberId.StartsWith("HV"))
                {
                    int n;
                    if (int.TryParse(m.MemberId.Substring(2), out n) && n > max)
                        max = n;
                }
            }
            return "HV" + (max + 1).ToString("D3");
        }

        private bool ValidateAllFields()
        {
            bool ok = true;

            string name = txtFullName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                errorProvider1.SetError(txtFullName, "Tên hội viên không được để trống");
                ok = false;
            }
            else if (!Regex.IsMatch(name, @"^[\p{L}\s]+$"))
            {
                errorProvider1.SetError(txtFullName, "Tên hội viên không được chứa ký tự đặc biệt");
                ok = false;
            }
            else
            {
                errorProvider1.SetError(txtFullName, "");
            }

            string phone = txtPhone.Text.Trim();
            if (!Regex.IsMatch(phone, @"^\d{10}$"))
            {
                errorProvider1.SetError(txtPhone, "Số điện thoại phải đúng 10 chữ số");
                ok = false;
            }
            else
            {
                errorProvider1.SetError(txtPhone, "");
            }

            string feeText = txtFee.Text.Trim();
            int feeValue;
            if (!int.TryParse(feeText, out feeValue) || feeValue <= 0)
            {
                errorProvider1.SetError(txtFee, "Phí dịch vụ phải là số nguyên dương");
                ok = false;
            }
            else
            {
                errorProvider1.SetError(txtFee, "");
            }

            return ok;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateAllFields()) return;

            var m = new MemberModel
            {
                MemberId = GenerateNextId(),
                FullName = txtFullName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Package = cboPackage.SelectedItem != null ? cboPackage.SelectedItem.ToString() : "Theo tháng",
                StartDate = dtpStartDate.Value,
                Fee = decimal.Parse(txtFee.Text.Trim())
            };

            members.Add(m);
            bs.Position = members.Count - 1;
            MessageBox.Show("Thêm mới hội viên thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (bs.Current == null)
            {
                MessageBox.Show("Vui lòng chọn hội viên cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateAllFields()) return;

            var m = bs.Current as MemberModel;
            m.FullName = txtFullName.Text.Trim();
            m.Phone = txtPhone.Text.Trim();
            m.Package = cboPackage.SelectedItem != null ? cboPackage.SelectedItem.ToString() : "Theo tháng";
            m.StartDate = dtpStartDate.Value;
            m.Fee = decimal.Parse(txtFee.Text.Trim());

            MessageBox.Show("Cập nhật thông tin hội viên thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bs.Current == null)
            {
                MessageBox.Show("Vui lòng chọn hội viên cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var m = bs.Current as MemberModel;
            var result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa hội viên '" + m.FullName + "' (Mã: " + m.MemberId + ")?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                members.Remove(m);
                ClearForm();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}