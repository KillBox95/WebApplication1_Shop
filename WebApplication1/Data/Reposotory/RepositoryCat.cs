using System.Collections.Generic;
using WebApplication1.Data.Interface;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.Reposotory
{
    public class RepositoryCat : iTovarCat
    {
        private readonly AppDBContent AppDBcontent;

        public RepositoryCat(AppDBContent appDBcontent)
        {
            this.AppDBcontent = appDBcontent;

        }
        public IEnumerable<Category> Allcategorys => AppDBcontent.Category;
    }
}
