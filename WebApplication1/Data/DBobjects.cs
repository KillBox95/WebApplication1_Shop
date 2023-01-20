using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http.Metadata;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Data.Models;

namespace WebApplication1.Data
{
    public class DBobjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Tovar.Any())
            {
                content.AddRange(
                    new Tovar
                    {
                        name = "Кровельные саморезы",
                        img = "/img/Krovelnye-samorezy.jpg",
                        price = 150,
                        count = 10,
                        isFavorite = true,
                        Category = Categories["1 степень качества"]
                    },

                    new Tovar
                    {
                        name = "Саморезы для сэндвич-панелей",
                        img = "/img/Sjendvich-panelej.jpg",
                        price = 300,
                        count = 15,
                        isFavorite = true,
                        Category = Categories["2 степень качества"]
                    },

                    new Tovar
                    {
                        name = "Саморезы для оконного профиля",
                        img = "/img/Sjendvich-panelej.jpg",
                        price = 300,
                        count = 40,
                        isFavorite = true,
                        Category = Categories["1 степень качества"]
                    },
                    new Tovar
                    {
                        name = "Саморезы по бетону",
                        img = "/img/Samorezy-po-betonu.jpg",
                        price = 400,
                        count = 40,
                        isFavorite = false,
                        Category = Categories["2 степень качества"]
                    },
                    new Tovar
                    {
                        name = "Саморез конструкционный",
                        img = "/img/Samorez-konstrukcionnyj.jpg",
                        price = 300,
                        count = 10,
                        isFavorite = false,
                        Category = Categories["1 степень качества"]
                    },
                    new Tovar
                    {
                        name = "Мебельные саморезы",
                        img = "/img/Mebelnye.jpg",
                        price = 300,
                        count = 100,
                        isFavorite = false,
                        Category = Categories["2 степень качества"]
                    }
                    );
            }

            content.SaveChanges();
        }

        private static Dictionary<string, Category> Category;
        public static Dictionary<string, Category> Categories 
        { 
           get
            {
                if(Category == null)
                {
                    var list = new Category[]
                    {
                        new Category
                    {
                        catogoryName = "1 степень качества"
                    },
                    new Category
                    {
                        catogoryName = "2 степень качества"
                    }
                    };
                    Category = new Dictionary<string, Category>();
                    foreach(Category Element in list)
                        Category.Add(Element.catogoryName, Element);
                }

                return Category;
            } 
        }
    }
}
