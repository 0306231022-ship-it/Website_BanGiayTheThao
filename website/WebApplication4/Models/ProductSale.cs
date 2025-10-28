namespace WebApplication4.Models
{
    public class ProductSale
    {
        public int ProductSaleID { get; set; }
        public string SaleType { get; set; } = string.Empty;
        public int SaleValue { get; set; }
        public DateTime SaleTime { get; set; }
        public int ProductID { get; set; }
        public int SaleStatus { get; set; }
    }
}
