namespace WebApplication4.Models
{
    public class Users
    {
        public int UserID { get; set; }
        public string UserName { get; set; }= string.Empty;
        public string UserEmail { get; set; } = string.Empty;
        public string UserPhone { get; set; } = string.Empty ;
        public string UserSex { get; set; }=string.Empty;
        public DateTime UserBirtDay { get; set; }
        public string Password { get; set; }= string.Empty;
        public string UserAvata { set; get; }=string.Empty;

    }
}
