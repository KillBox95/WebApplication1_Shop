using System.Collections.Generic;

namespace WebApplication1.Documenty.Modely
{
    public class Category
    {
        public int id { get; set; }

        public string catogoryName { get; set; }

        public string desc { get; set; }

        public List<Tovar> tovar { get; set; }
    }
}
