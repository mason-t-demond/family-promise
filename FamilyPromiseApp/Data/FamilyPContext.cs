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
        public DbSet<Person>Persons{ get; set; }
        public DbSet<Case>Case{ get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Referral>().ToTable(nameof(Referral));
            modelBuilder.Entity<Resource>().ToTable("Resource");
            modelBuilder.Entity<Person>().ToTable("Person");
            modelBuilder.Entity<Case>().ToTable("Case");

        }
        public DbSet<FamilyPromiseApp.Models.Resource> Resource { get; set; }
        public DbSet<FamilyPromiseApp.Models.Person> Person { get; set; } = default!;

        
    }
}