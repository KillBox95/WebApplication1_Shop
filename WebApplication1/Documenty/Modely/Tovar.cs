namespace WebApplication1.Documenty.Modely
{
    public class Tovar
    {

        public int id { get; set; }
        public string name { get; set; }
        public string img { get; set; }
        public ushort price { get; set; }
        public int count { get; set; }
        public int categoryID { get; set; }
        public virtual Category Category { get; set; }

    }
}
