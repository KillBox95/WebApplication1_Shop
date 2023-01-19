using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Documenty.Interface;
using WebApplication1.Documenty.Modely;

namespace WebApplication1.Documenty.Reposotory
{
    public class RepositoryTov : iAllTovars
    {
        private readonly AppDBContent AppDBcontent;

        public RepositoryTov(AppDBContent appDBcontent)
        {
            this.AppDBcontent = appDBcontent;
        }

        public IEnumerable<Tovar> Tovars => AppDBcontent.Tovar.Include(c => c.Category);

        public Tovar getObjectTovar(int TovarId) => AppDBcontent.Tovar.FirstOrDefault(p => p.id== TovarId);

    }
}
