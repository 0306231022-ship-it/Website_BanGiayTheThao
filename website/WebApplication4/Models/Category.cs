namespace WebApplication4.Models
{
    public class Category
    {
        public int CategoryID;
        public string CategoryName { set; get; }=string.Empty;
        public string CategoryOrgin { set; get; }= string.Empty;
        public string CategoryUrl { set; get; }=string.Empty;
        public int Status;
    }
}
