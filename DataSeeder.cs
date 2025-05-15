using CodersCollab.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace CodersCollab.Data
{
    public static class DataSeeder
    {
        public static void Seed(IServiceProvider serviceProvider)
        {
            using var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>());

            if (!context.Users.Any())
            {
                context.Users.Add(new User { Name = "Admin", IsAdmin = true });
                context.SaveChanges();
            }
        }
    }
}