namespace WebApplication4.Models
{
    public class DiscountCode
    {
        public int DiscountCodeID { get; set; }
        public string DiscountValue { get; set; }= string.Empty;
        public DateTime DisountExpirationDate { get; set; }
        public int QuantityUsed { get; set; }
        public int litmitUsed { get; set; }
        public int Status { get; set; }
    }
}
