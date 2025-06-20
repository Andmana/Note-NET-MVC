using inject_db.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace inject_db.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base  (options)
        {
            
        }

        public DbSet<Student> Students { get; set; }

    }
}
