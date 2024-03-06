using Microsoft.EntityFrameworkCore;
using FamilyPromiseApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FamilyPromiseApp.Data
{
    public class FamilyPContext : IdentityDbContext
    {

        public FamilyPContext (DbContextOptions<FamilyPContext> options)
            : base(options)
        {
        }
        public DbSet<Referral>Referrals{ get; set; }
        public DbSet<Resource>Resources{ get; set; }
        public DbSet<Person>Persons{ get; set; }
        public DbSet<Case>Case{ get; set; }
        public DbSet<IntakeModel>Intake{ get; set; }
        public DbSet<Child>Child{ get; set; }
        public DbSet<Adult>Adult{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<SelectListGroup>().HasNoKey();

            modelBuilder.Entity<Referral>().ToTable(nameof(Referral));
            modelBuilder.Entity<Resource>().ToTable("Resource");
            modelBuilder.Entity<Person>().ToTable("Person");
            modelBuilder.Entity<Case>().ToTable("Case");
            modelBuilder.Entity<IntakeModel>().ToTable("IntakeModel");
            modelBuilder.Entity<Child>().ToTable("Child");
            modelBuilder.Entity<Adult>().ToTable("Adult");
        }
        public DbSet<FamilyPromiseApp.Models.Resource> Resource { get; set; }
        public DbSet<FamilyPromiseApp.Models.Person> Person { get; set; } = default!;
        public object IntakeModel { get; internal set; }
    }
}