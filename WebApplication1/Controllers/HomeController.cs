using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data.Interface;
using WebApplication1.Data.Models;
using WebApplication1.ViewsModls;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly iAllTovars _tovRep;
        

        public HomeController(iAllTovars tovRep)
        {
            _tovRep = tovRep;
        }
        public ViewResult Index()
        {
            var homeTovars = new HomeViewModls
            {
              FavTovar = _tovRep.getFavTovar
            };
            return View(homeTovars);
        }
    }
}
