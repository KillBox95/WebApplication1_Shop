using System.Collections.Generic;
using System;

namespace WebApplication1.Data.Models
{
    public class ZakazDetail
    {
        public int id { get; set; }
        public int zakazId { get; set; }
        public int tovarId { get; set; }
        public uint price { get; set; }
        public virtual Tovar tovar { get; set; }
        public virtual Zakaz zakaz { get; set; }

     }
}
