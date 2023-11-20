using Microsoft.EntityFrameworkCore;
using OneFB.Models;

namespace OneFB.OneFBContext
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
                    

        }
        public DbSet<Slider> Sliders { get; set; }
    }
}
