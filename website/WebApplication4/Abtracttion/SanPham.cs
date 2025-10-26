using WebApplication4.Models;

namespace WebApplication4.Abstraction
{
    public interface ISanPham
    {
        IQueryable<Product> Products { get; }
        IQueryable<Product> GetDuLieu();
    }
}
