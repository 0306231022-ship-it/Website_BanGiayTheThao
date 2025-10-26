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
    }
}
