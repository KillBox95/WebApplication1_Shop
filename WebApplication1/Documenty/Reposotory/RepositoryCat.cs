using System.Collections.Generic;
using WebApplication1.Documenty.Interface;
using WebApplication1.Documenty.Modely;

namespace WebApplication1.Documenty.Reposotory
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
