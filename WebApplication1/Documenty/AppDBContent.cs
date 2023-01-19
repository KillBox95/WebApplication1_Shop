using Microsoft.EntityFrameworkCore;
using WebApplication1.Documenty.Modely;

namespace WebApplication1.Documenty
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }

        public DbSet<Tovar> Tovar { get; set; }
        public DbSet<Category> Category { get; set; }
    
    }
}
