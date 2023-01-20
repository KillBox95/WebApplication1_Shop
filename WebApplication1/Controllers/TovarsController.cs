using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data.Models;
using WebApplication1.Data.Interface;
using WebApplication1.ViewsModls;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Controllers
{
    public class TovarsController : Controller {

        private readonly iAllTovars _allTovars;
        private readonly iTovarCat _allCatTov;

        public TovarsController (iAllTovars iAllTovars, iTovarCat iTovarCat)
        {
            _allTovars = iAllTovars;
            _allCatTov = iTovarCat;
        }
        [Route("Tovars/List")]
        [Route("Tovars/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Tovar> tovars = null;
            string tovarCat = "";
            if(string.IsNullOrEmpty(category)) 
            {
                tovars = _allTovars.Tovars.OrderBy(i => i.id);
            }
            else
            {
                if (string.Equals("1", category, System.StringComparison.OrdinalIgnoreCase))
                {
                    tovars = _allTovars.Tovars.Where(i => i.categoryName.Equals("1 степень качества")).OrderBy(i => i.id);
                    tovarCat = "1 степень качества";
                }
                else if (string.Equals("2", category, System.StringComparison.OrdinalIgnoreCase))
                {
                    tovars = _allTovars.Tovars.Where(i => i.categoryName.Equals("2 степень качества")).OrderBy(i => i.id);
                    tovarCat = "2 степень качества";
                }

            }
            var tovarObj = new TovarsListViewModls
            {
                AllTovars = tovars,
                currCategory = tovarCat
            };

            ViewBag.Title = "Страница магазина";

            return View(tovarObj);
        }


    }
}
