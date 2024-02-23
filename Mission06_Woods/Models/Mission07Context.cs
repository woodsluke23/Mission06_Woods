using Microsoft.EntityFrameworkCore;
namespace Mission06_Woods.Models
{
    public class Mission07Context : DbContext
    {
        public Mission07Context(DbContextOptions<Mission07Context> options) : base (options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
