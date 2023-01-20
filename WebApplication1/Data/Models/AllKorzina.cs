using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Data.Models
{
    public class AllKorzina
    {
        private readonly AppDBContent AppDBcontent;

        public AllKorzina(AppDBContent appDBcontent)
        {
            this.AppDBcontent = appDBcontent;
        }
        public string KorzinaId { get; set; }

        public List<Korzina> KorzinaList { get; set; }
        
        public static AllKorzina GetTovar(IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = service.GetService<AppDBContent>();
            string KorzinaId = session.GetString("KorzId") ?? Guid.NewGuid().ToString();

            session.SetString("KorzId", KorzinaId);


            return new AllKorzina(context) { KorzinaId = KorzinaId };
        }
        public void AddToKorz(Tovar tovar)
        {
            AppDBcontent.Korzina.Add(new Korzina
            {
                ShopTovarId = KorzinaId,
                Tovar = tovar,
                price = tovar.price
            });

            AppDBcontent.SaveChanges();
        }

        public List<Korzina> GetKorzina()
        {
            return AppDBcontent.Korzina.Where(c => c.ShopTovarId == KorzinaId).Include(s => s.Tovar).ToList();
        }
    }
}
