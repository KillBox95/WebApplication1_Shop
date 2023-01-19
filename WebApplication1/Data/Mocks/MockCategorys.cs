using System.Collections.Generic;
using WebApplication1.Data.Models;
using WebApplication1.Data.Interface;

namespace WebApplication1.Data.Mocks
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

