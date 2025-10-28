namespace WebApplication4.Models
{
    public class Products
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }=string.Empty;
        public string ProductPrice { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public int Inventory {  get; set; }
        public string ProductDescrible { set; get; } = string.Empty;
        public int Status { get; set; }

    }
}
