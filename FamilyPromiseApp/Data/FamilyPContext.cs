using Microsoft.EntityFrameworkCore;
using FamilyPromiseApp.Models;

namespace FamilyPromiseApp.Data
{
    public class FamilyPContext : DbContext
    {

        public FamilyPContext (DbContextOptions<FamilyPContext> options)
            : base(options)
        {
        }
        public DbSet<Referral>Referrals{ get; set; }
        public DbSet<Resource>Resources{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Referral>().ToTable(nameof(Referral));
            modelBuilder.Entity<Resource>().ToTable("Resource");

        }
        public DbSet<FamilyPromiseApp.Models.Resource> Resource { get; set; }

        
    }
}
