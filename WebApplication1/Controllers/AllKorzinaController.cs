using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApplication1.Data.Interface;
using WebApplication1.Data.Models;
using WebApplication1.ViewsModls;

namespace WebApplication1.Controllers
{
    public class AllKorzinaController : Controller
    {
        private readonly iAllTovars _tovRep;
        private readonly AllKorzina _allKorz;

        public AllKorzinaController(iAllTovars tovRep, AllKorzina allKorz)
        {
            _tovRep = tovRep;
            _allKorz = allKorz;
        }

        public ViewResult Index()
        {
            var item = _allKorz.GetKorzina();
            _allKorz.KorzinaList = item;

            var obj = new AllKorzViewModls
            {
                allKorzina = _allKorz
        };

            return View(obj); 
        }

            public RedirectToActionResult addToKorz(int id)
        {
            var item = _tovRep.Tovars.FirstOrDefault(i => i.id == id);
            if(item != null)
            {
                _allKorz.AddToKorz(item);
            }
            return RedirectToAction("Index");
        }
    }
}
