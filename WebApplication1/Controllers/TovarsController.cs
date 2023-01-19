using Microsoft.AspNetCore.Mvc;
using WebApplication1.Documenty.Modely;
using WebApplication1.Documenty.Interface;
using WebApplication1.ViewsModls;

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
         
        public ViewResult List()
        {

            TovarsListViewModls obj = new TovarsListViewModls();
            ViewBag.Title = "Страница магазина";
            obj.AllTovars = _allTovars.Tovars;
            obj.currCategory = "Категории";
            return View(obj);
        }


    }
}
