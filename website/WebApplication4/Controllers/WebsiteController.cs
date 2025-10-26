using Microsoft.AspNetCore.Mvc;
using WebApplication4.Abstraction;
using WebApplication4.Middleware;

namespace WebApplication4.Controllers
{
    public class WebsiteController : Controller
    {
 
        public IActionResult SanPhamNoiBat()
        {
            return View();
        }
        public IActionResult GiayNam()
        {
            return View();
        }
        public IActionResult GiayNu()
        {
            return View();
        }
        public IActionResult SanPhamSale()
        {
            return View();
        }
        public IActionResult TrangBlog()
        {
            return View();
        }
        public IActionResult GioHang()
        {
            return View();
        }
    }
}
