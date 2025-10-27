using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult TrangChuAdmin()
        {
            return View();
        }
        public IActionResult CaiDatWebsite()
        {
            return PartialView("_CaiDatWebsite");
        }
        public IActionResult QuanLiBaiViet()
        {
            return PartialView("_QuanLiBaiViet");
        }
        public IActionResult ThemBaiViet()
        {
            return PartialView("_ThemBaiViet");
        }
        public IActionResult QuanLiSanPham()
        {
            return PartialView("_QuanLiSanPham");
        }
        public IActionResult ThemSanPham()
        {
            return PartialView("_ThemSanPhamMoi");
        }
        public IActionResult ThemSanPhamSale()
        {
            return PartialView("_ThemSanPhamSale");
        }
        public IActionResult QuanLiDanhMuc()
        {
            return PartialView("_QuanLiDanhMuc");
        }
        public IActionResult QuanLiDonHang()
        {
            return PartialView("_QuanLiDonHang");
        }
        public IActionResult ChiTietSanPham()
        {
            return PartialView("_ChiTietSanPham");
        }
        public IActionResult XemDonHang()
        {
            return PartialView("_XemDonHang");
        }
        public IActionResult HoaDon()
        {
            return PartialView("_HoaDon");
        }
        public IActionResult BinhLuan()
        {
            return PartialView("_QuanLiBinhLuan");
        }
        public IActionResult TaiKhoanCaNhan()
        {
            return PartialView("_TaiKhoan");
        }
        public IActionResult QuanLiNguoiDung()
        {
            return PartialView("_QuanLiNguoiDung");
        }
    }
}
