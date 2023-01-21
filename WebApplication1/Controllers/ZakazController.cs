using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data.Models;
using WebApplication1.Data;
using WebApplication1.Data.Interface;

namespace WebApplication1.Controllers
{
    public class ZakazController : Controller
    {
        private readonly iAllZakaz allZakaz;
        private readonly AllKorzina allKorzina;

        public ZakazController(iAllZakaz allZakaz, AllKorzina allKorzina)
        {
            this.allZakaz = allZakaz;
            this.allKorzina = allKorzina;
        }

        public IActionResult chekout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult chekout(Zakaz zakaz)
        {
            allKorzina.KorzinaList = allKorzina.GetKorzina();

            if(allKorzina.KorzinaList.Count == 0)
            {
                ModelState.AddModelError("", "КОРЗИНА ПУСТАЯ");
            }
            if(ModelState.IsValid)
            {
                allZakaz.createZakaz(zakaz);
                return RedirectToAction("Complete");
            };

            return View();
        }
        public IActionResult Complete()
        {
            ViewBag.Messeng = "Заказ успешно оббработан";
            return View(); 
        }
    }
}
