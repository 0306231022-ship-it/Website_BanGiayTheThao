namespace WebApplication4.Models
{
    public class Comments
    {
        public int CommentID { get; set; }
        public string CommentText { get; set; } = string.Empty;
        public int UserID { get; set; }
        public string CommentType { get; set; } = string.Empty;
        public int CommentStatus { get; set; }
    }
}
