namespace WebApplication4.Models
{
    public class Bill
    {
        public int BillID { get; set; }
        public int Quantity { get; set; }
        public int BillStatus { get; set; }
        public DateTime BillDate { get; set; }
        public int DeliveryStatus { get; set; }
        public int TotalAmount { get; set; }
    }
}
