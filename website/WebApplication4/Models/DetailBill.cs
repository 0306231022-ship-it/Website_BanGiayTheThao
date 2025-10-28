namespace WebApplication4.Models
{
    public class DetailBill
    {
        public int DetailBillID { get; set; }
        public string DetailBillName { get; set; } = string.Empty;
        public int DetailBillQuantity { get; set;} 
        public int DetailBillPrice { get; set; }
        public int BillID { get; set; }
    }
}
