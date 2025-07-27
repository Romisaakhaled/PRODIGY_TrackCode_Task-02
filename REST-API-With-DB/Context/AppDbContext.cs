using Microsoft.EntityFrameworkCore;
using REST_API_With_DB.Models;

namespace REST_API_With_DB.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
