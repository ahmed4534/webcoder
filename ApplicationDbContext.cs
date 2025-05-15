    using Microsoft.EntityFrameworkCore;
using CodersCollab.Models;

namespace CodersCollab.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Team> Teams { get; set; }
        public DbSet<User> Users { get; set; }
    }
}