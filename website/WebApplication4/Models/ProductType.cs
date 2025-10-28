namespace WebApplication4.Models
{
    public class ProductType
    {
        public int ProductTypeID { get; set; }
        public string TypeName { get; set; } = string.Empty;
        public int ProductID { get; set; }
        public int QuanTity { get; set; }
        public int TypeDescrible { get; set; }

    }
}
