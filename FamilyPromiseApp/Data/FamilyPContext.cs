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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Referral>().ToTable("Referral");
        }

        
    }
}
