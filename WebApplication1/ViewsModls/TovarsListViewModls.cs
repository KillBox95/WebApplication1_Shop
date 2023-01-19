using System.Collections;
using System.Collections.Generic;
using WebApplication1.Data.Models;

namespace WebApplication1.ViewsModls
{
    public class TovarsListViewModls
    {
        public IEnumerable<Tovar> AllTovars { get; set; }

        public string currCategory { get; set; }

    }
}