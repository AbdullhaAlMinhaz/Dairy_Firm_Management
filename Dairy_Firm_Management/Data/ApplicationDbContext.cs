using Dairy_Firm_Management.DataModel;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Dairy_Firm_Management.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CowInventory> CowInventories { get; set; } = default!;
        public DbSet<FeedingManagement> FeedingManagements { get; set; } = default!;
        public DbSet<MeatProductionTracking> MeatProductions { get; set; } = default!;
        public DbSet<MilkProductionTracking> MilkProductions { get; set; } = default!;
        public DbSet<VaccineApplicationRecords> VaccineApplications { get; set; } = default!;
        public DbSet<VaccineInventory> VaccineInventories { get; set; } = default!;


    }
}
