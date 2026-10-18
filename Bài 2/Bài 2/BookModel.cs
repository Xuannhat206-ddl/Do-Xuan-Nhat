namespace Bài_2
{
    public class BookModel
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string TacGia { get; set; }
        public string TheLoai { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuong { get; set; }
        public string AnhBia { get; set; }

        public decimal ThanhTien
        {
            get { return GiaBan * SoLuong; }
        }
    }
}