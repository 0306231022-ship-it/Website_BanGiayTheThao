namespace WebApplication4.Models
{
    public class Blog
    {
        public int BlogID { get; set; }
        public string BlogHeader { get; set; } = string.Empty;
        public string BlogUrl { get; set; }= string.Empty;
        public string BlogContent { get; set; } = string.Empty;
        public string BlogHeaderSale { get; set; }=string.Empty;
        public string BlogDescrible { set; get; }=string.Empty;
        public string BlogSummary { set; get; }=string.Empty;
        public string BlogCreator { set; get; }=string.Empty;
        public DateTime DatePost { set; get; }=DateTime.Now;
        public string BlogType { set; get; } = string.Empty;
        public string Avata { set; get; }=string.Empty;
        public int Status { get; set; }


    }
}
