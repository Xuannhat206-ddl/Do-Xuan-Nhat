using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bài_2
{
    public partial class Form1 : Form
    {
        private BindingList<BookModel> bookList = new BindingList<BookModel>();
        private System.Windows.Forms.Timer statusTimer;
        private string currentCoverFile = "";
        private BookModel editingBook = null;

        public Form1()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            dgvBooks.DataSource = bookList;
            bookList.ListChanged += (s, e) => UpdateStatusBar();
            UpdateStatusBar();

            statusTimer = new System.Windows.Forms.Timer { Interval = 1000 };
            statusTimer.Tick += (s, e) => lblTime.Text = "Thời gian: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            statusTimer.Start();
        }

        private void UpdateStatusBar()
        {
            lblCount.Text = "Tổng số đầu sách: " + bookList.Count;
            decimal total = 0m;
            foreach (var b in bookList) total += b.ThanhTien;
            lblTotal.Text = "Tổng giá trị: " + total.ToString("N0", CultureInfo.InvariantCulture) + " VNĐ";
        }

        private void btnLoadCover_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn ảnh bìa sách";
                ofd.Filter = "Image files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    currentCoverFile = ofd.FileName;
                    ShowImage(ofd.FileName);
                }
            }
        }

        private void ShowImage(string path)
        {
            try
            {
                if (picBookCover.Image != null)
                {
                    picBookCover.Image.Dispose();
                    picBookCover.Image = null;
                }
                using (var tmp = Image.FromFile(path))
                {
                    picBookCover.Image = new Bitmap(tmp);
                }
            }
            catch
            {
                MessageBox.Show("Không thể tải ảnh bìa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!IsFormValid(out BookModel b)) return;
            bookList.Add(b);
            ClearInputs();
            UpdateStatusBar();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (editingBook == null)
            {
                MessageBox.Show("Vui lòng chọn 1 sách từ danh sách để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!IsFormValid(out BookModel b)) return;

            editingBook.MaSach = b.MaSach;
            editingBook.TenSach = b.TenSach;
            editingBook.TacGia = b.TacGia;
            editingBook.TheLoai = b.TheLoai;
            editingBook.GiaBan = b.GiaBan;
            editingBook.SoLuong = b.SoLuong;
            if (!string.IsNullOrEmpty(b.AnhBia)) editingBook.AnhBia = b.AnhBia;

            dgvBooks.Refresh();
            UpdateStatusBar();
            ClearInputs();
            MessageBox.Show("Đã cập nhật thông tin sách!", "Thành công");
        }

        private bool IsFormValid(out BookModel book)
        {
            book = null;
            if (string.IsNullOrWhiteSpace(txtMa.Text) || string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã sách và Tên sách!", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!decimal.TryParse(txtGia.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal gia) || gia < 0)
            {
                MessageBox.Show("Giá bán không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!int.TryParse(txtSoLuong.Text, out int sl) || sl < 0)
            {
                MessageBox.Show("Số lượng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            book = new BookModel
            {
                MaSach = txtMa.Text.Trim(),
                TenSach = txtTen.Text.Trim(),
                TacGia = txtTacGia.Text.Trim(),
                TheLoai = txtTheLoai.Text.Trim(),
                GiaBan = gia,
                SoLuong = sl,
                AnhBia = string.IsNullOrEmpty(currentCoverFile) ? "" : Path.GetFileName(currentCoverFile)
            };
            return true;
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var b = dgvBooks.CurrentRow.DataBoundItem as BookModel;
            if (b == null) return;

            if (MessageBox.Show($"Xóa sách \"{b.TenSach}\"?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bookList.Remove(b);
                ClearInputs();
            }
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            string key = txtSearch.Text.Trim();
            if (string.IsNullOrWhiteSpace(key)) return;

            var found = bookList.FirstOrDefault(b =>
                b.MaSach.Equals(key, StringComparison.OrdinalIgnoreCase) ||
                b.TenSach.IndexOf(key, StringComparison.OrdinalIgnoreCase) >= 0);

            if (found == null)
            {
                MessageBox.Show("Không tìm thấy sách!", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int idx = bookList.IndexOf(found);
            dgvBooks.ClearSelection();
            dgvBooks.Rows[idx].Selected = true;
            dgvBooks.CurrentCell = dgvBooks.Rows[idx].Cells[0];
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Mở file CSV";
                ofd.Filter = "CSV files (*.csv)|*.csv";
                if (ofd.ShowDialog() != DialogResult.OK) return;

                try
                {
                    bookList.RaiseListChangedEvents = false;
                    bookList.Clear();
                    var lines = File.ReadAllLines(ofd.FileName, Encoding.UTF8);

                    for (int i = 1; i < lines.Length; i++)
                    {
                        if (string.IsNullOrWhiteSpace(lines[i])) continue;
                        string[] p = ParseCsvLine(lines[i]);
                        if (p.Length < 7) continue;

                        bookList.Add(new BookModel
                        {
                            MaSach = p[0],
                            TenSach = p[1],
                            TacGia = p[2],
                            TheLoai = p[3],
                            GiaBan = decimal.TryParse(p[4], NumberStyles.Any, CultureInfo.InvariantCulture, out var g) ? g : 0m,
                            SoLuong = int.TryParse(p[5], out var sl) ? sl : 0,
                            AnhBia = p[6]
                        });
                    }
                    bookList.RaiseListChangedEvents = true;
                    bookList.ResetBindings();
                    UpdateStatusBar();
                    MessageBox.Show($"Đã tải {bookList.Count} đầu sách từ file!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đọc file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            if (bookList.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu để lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Lưu báo cáo danh sách sách";
                sfd.Filter = "CSV files (*.csv)|*.csv";
                sfd.FileName = "books_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv";
                if (sfd.ShowDialog() != DialogResult.OK) return;

                try
                {
                    var sb = new StringBuilder();
                    sb.AppendLine("MaSach,TenSach,TacGia,TheLoai,GiaBan,SoLuong,AnhBia");
                    foreach (var b in bookList)
                    {
                        sb.AppendLine(string.Join(",",
                            CsvField(b.MaSach),
                            CsvField(b.TenSach),
                            CsvField(b.TacGia),
                            CsvField(b.TheLoai),
                            b.GiaBan.ToString(CultureInfo.InvariantCulture),
                            b.SoLuong.ToString(),
                            CsvField(b.AnhBia)));
                    }
                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Đã lưu file CSV thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi ghi file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var b = dgvBooks.Rows[e.RowIndex].DataBoundItem as BookModel;
            if (b == null) return;

            editingBook = b;

            txtMa.Text = b.MaSach;
            txtTen.Text = b.TenSach;
            txtTacGia.Text = b.TacGia;
            txtTheLoai.Text = b.TheLoai;
            txtGia.Text = b.GiaBan.ToString("0.##", CultureInfo.InvariantCulture);
            txtSoLuong.Text = b.SoLuong.ToString();

            currentCoverFile = "";
            if (!string.IsNullOrEmpty(b.AnhBia))
            {
                string p = Path.Combine(Application.StartupPath, b.AnhBia);
                if (File.Exists(p))
                {
                    ShowImage(p);
                    currentCoverFile = p;
                }
                else if (File.Exists(b.AnhBia))
                {
                    ShowImage(b.AnhBia);
                    currentCoverFile = b.AnhBia;
                }
                else
                {
                    if (picBookCover.Image != null)
                    {
                        picBookCover.Image.Dispose();
                        picBookCover.Image = null;
                    }
                }
            }
            else
            {
                if (picBookCover.Image != null)
                {
                    picBookCover.Image.Dispose();
                    picBookCover.Image = null;
                }
            }
        }

        private void ClearInputs()
        {
            txtMa.Clear();
            txtTen.Clear();
            txtTacGia.Clear();
            txtTheLoai.Clear();
            txtGia.Clear();
            txtSoLuong.Clear();
            if (picBookCover.Image != null)
            {
                picBookCover.Image.Dispose();
                picBookCover.Image = null;
            }
            currentCoverFile = "";
            editingBook = null;
            dgvBooks.ClearSelection();
            txtMa.Focus();
        }

        private static string CsvField(string s)
        {
            if (string.IsNullOrEmpty(s)) return "";
            if (s.IndexOf(',') >= 0 || s.IndexOf('"') >= 0 || s.IndexOf('\n') >= 0 || s.IndexOf('\r') >= 0)
                return "\"" + s.Replace("\"", "\"\"") + "\"";
            return s;
        }

        private static string[] ParseCsvLine(string line)
        {
            var list = new List<string>();
            bool inQuotes = false;
            var sb = new StringBuilder();
            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];
                if (inQuotes)
                {
                    if (c == '"')
                    {
                        if (i + 1 < line.Length && line[i + 1] == '"')
                        { sb.Append('"'); i++; }
                        else inQuotes = false;
                    }
                    else sb.Append(c);
                }
                else
                {
                    if (c == '"') inQuotes = true;
                    else if (c == ',') { list.Add(sb.ToString()); sb.Clear(); }
                    else sb.Append(c);
                }
            }
            list.Add(sb.ToString());
            return list.ToArray();
        }
    }
}