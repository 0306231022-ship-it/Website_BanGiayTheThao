using WebApplication4.Abstraction;
using WebApplication4.Models;

namespace WebApplication4.Repository
{
    public class DuLieuGia_SanPham : ISanPham
    {
        public IQueryable<Product> Products => new List<Product>
        {
    
        }.AsQueryable();
        public IQueryable<Product> GetDuLieu()
        {
            return Products;
        }
    }
}
