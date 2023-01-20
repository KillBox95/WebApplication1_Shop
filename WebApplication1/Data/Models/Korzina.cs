namespace WebApplication1.Data.Models
{
    public class Korzina
    {

        public int id { get; set; }
        public Tovar Tovar { get; set; }
        public int price { get; set; }
        public string ShopTovarId { get; set; }
    }
}
