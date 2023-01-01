using Microsoft.EntityFrameworkCore;

namespace NasilAraba.Models
{
    public class GalleryContext:DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=aspnet-NasilAraba-bed81760-620f-44c7-aa5b-274ea4db464d;Trusted_Connection=True;");
        }
    }
}
