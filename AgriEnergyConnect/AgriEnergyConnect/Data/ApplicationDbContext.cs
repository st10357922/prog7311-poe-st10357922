using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AgriEnergyConnect.Models;
using Microsoft.AspNetCore.Identity;

namespace AgriEnergyConnect.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<FarmerProfile> FarmerProfiles { get; set; }
    }
}

