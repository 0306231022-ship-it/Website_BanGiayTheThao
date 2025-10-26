
namespace WebApplication4.Models
{
    public class Product
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }=string.Empty;
        public string MauSac { get; set; }= string.Empty;
        public string SizeSP { get; set; } = string.Empty;
        public int LoaiSP { get; set; }
        public int SoLuong { get; set; }
        public int TrangThai { get; set; }
    }
}