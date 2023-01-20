using Microsoft.EntityFrameworkCore;
using WebApplication1.Data.Models;

namespace WebApplication1.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }

        public DbSet<Tovar> Tovar { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Korzina> Korzina { get; set; }



    }
}
