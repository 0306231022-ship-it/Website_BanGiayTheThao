
using System.Globalization;

namespace WebApplication4.Models
{
    public class SettingƯebsite
    {
        public string NameWebsite { get; set; } = string.Empty;
        public string Email { get; set; }=string.Empty;
        public string Link_FaceBook { get; set; }= string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Logo { get; set; }=string.Empty ;
        public string NumberPhone { get; set; }=string.Empty;
        public string  Describle { get; set; }=string.Empty ;
        public string CurrencyUnit { get; set; }=string.Empty ;
        public int ShoppingFree { get; set; }
    }
}