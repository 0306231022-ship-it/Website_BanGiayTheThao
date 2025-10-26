using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class NguoiDungController : Controller
    {
        public IActionResult TrangChuNguoiDung()
        {
            return View();
        }
        public IActionResult TongQuan()
        {
            return PartialView("_TongQuan");
        }
        public IActionResult MyDonHang()
        {
            return PartialView("_MyDonHang");
        }
        public IActionResult ThongTinNguoiDung()
        {
            return PartialView("_ThongTinNguoiDung");
        }
        public IActionResult SanPhamYeuThich()
        {
            return PartialView("_SanPhamYeuThich");
        }
        public IActionResult SoDiaChi()
        {
            return PartialView("_SoDiaChi");
        }
        public IActionResult CapNhatMatKhau() 
        {
            return PartialView("_CapNhatMatKhau");
        }

    }
}
