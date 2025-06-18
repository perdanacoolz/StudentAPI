using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace StudentAPI.Models
{
    public class APIDbContext: IdentityDbContext<IdentityUser>
    {
        public APIDbContext(DbContextOptions<APIDbContext> option):base(option)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<User> Users_ { get; set; }
    }
}
