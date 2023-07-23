using Microsoft.EntityFrameworkCore;
using RecetteWebAppMVC.Models;

namespace RecetteWebAppMVC.Data
{
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
            {
            }
            public DbSet<Recette> Categories { get; set; }
        }

}
