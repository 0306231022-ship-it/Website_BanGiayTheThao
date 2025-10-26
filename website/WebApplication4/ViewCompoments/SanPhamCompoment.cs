using Microsoft.AspNetCore.Mvc;
using WebApplication4.Abstraction;

namespace WebApplication4.ViewComponents
{
    public class SanPhamViewComponent : ViewComponent
    {
        private readonly ISanPham _repository;

        public SanPhamViewComponent(ISanPham repository)
        {
            _repository = repository;
        }

        public IViewComponentResult Invoke()
        {
            var ds = _repository.GetDuLieu();
            return View(ds); 
        }
    }
}

