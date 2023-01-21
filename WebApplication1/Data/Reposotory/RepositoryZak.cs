using System;
using System.Data;
using WebApplication1.Data.Interface;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.Reposotory
{
    public class RepositoryZak : iAllZakaz
    {
        private readonly AppDBContent appDBContent;
        private readonly AllKorzina allKorzina;

        public RepositoryZak(AppDBContent appDBContent, AllKorzina allKorzina)
        {
            this.appDBContent = appDBContent;
            this.allKorzina = allKorzina;
        }

        public void createZakaz(Zakaz zakaz)
        {
            zakaz.zakazTime = DateTime.Now;
            appDBContent.Zakazs.Add(zakaz);

            var items = allKorzina.KorzinaList;

            foreach (var item in items)
            {
                var zakazDetail = new ZakazDetail()
                {
                    tovarId = item.Tovar.id,
                    zakazId = zakaz.id,
                    price = item.Tovar.price
                };
                appDBContent.ZakazDetail.Add(zakazDetail);
            }
            appDBContent.SaveChanges();
        }


    }
}