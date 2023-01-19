using System.Collections.Generic;
using System.Linq;
using System.Xml;
using WebApplication1.Documenty.Modely;
using WebApplication1.Documenty.Interface;

namespace WebApplication1.Documenty.Mocks
{
    public class MockTovars : iAllTovars {

        private readonly iTovarCat _categoryTovars = new MockCategorys();
        public IEnumerable<Tovar> Tovars
        {

            get
            {
                return new List<Tovar>
                {
                    new Tovar {name = "Кровельные саморезы",
                        img = "/img/Krovelnye-samorezy.jpg", 
                        price = 150, 
                        count = 10, 
                        Category = _categoryTovars.Allcategorys.Last()},

                    new Tovar {name = "Саморезы для сэндвич-панелей",
                        img = "/img/Sjendvich-panelej.jpg",
                        price = 300,
                        count = 15,
                        Category = _categoryTovars.Allcategorys.First()},

                    new Tovar {name = "Саморезы для оконного профиля",
                        img = "/img/Sjendvich-panelej.jpg",
                        price = 300,
                        count = 40,
                        Category = _categoryTovars.Allcategorys.Last()},
                    new Tovar {name = "Саморезы по бетону",
                        img = "/img/Samorezy-po-betonu.jpg",
                        price = 400,
                        count = 40,
                        Category = _categoryTovars.Allcategorys.First()},
                    new Tovar {name = "Саморез конструкционный",
                        img = "/img/Samorez-konstrukcionnyj.jpg",
                        price = 300,
                        count = 10,
                        Category = _categoryTovars.Allcategorys.First()},
                    new Tovar {name = "Мебельные саморезы",
                        img = "/img/Mebelnye.jpg",
                        price = 300,
                        count = 100,
                        Category = _categoryTovars.Allcategorys.Last()},
                };
            }
        }

        public Tovar getObjectTovar(int TovarId)
        {
            throw new System.NotImplementedException();
        }
    }

}

