using System.Collections.Generic;
using WebApplication1.Documenty.Modely;
using WebApplication1.Documenty.Interface;

namespace WebApplication1.Documenty.Mocks
{

    public class MockCategorys : iTovarCat
    {
        public IEnumerable<Category> Allcategorys
        {
            get
            {
                return new List<Category>{
                    new Category
                    {
                        catogoryName = "1 степень качества"
                    },
                    new Category
                    {
                        catogoryName = "2 степень качества"
                    }
                }; 
            }
        }
    }
}

