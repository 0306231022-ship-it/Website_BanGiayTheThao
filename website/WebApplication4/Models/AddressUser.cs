namespace WebApplication4.Models
{
    public class AddressUser
    {
        public int AddressUserID;
        public string AddressName { set; get; } = string.Empty;
        public int UsersID { set; get; }
        public int AddressStatus { set; get; }
    }
}
