using Microsoft.EntityFrameworkCore;
namespace Mission06_Woods.Models
{
    public class Mission06Context : DbContext
    {
        public Mission06Context(DbContextOptions<Mission06Context> options) : base (options)
        {

        }

        public DbSet<Application> Applications { get; set; }
    }
}
