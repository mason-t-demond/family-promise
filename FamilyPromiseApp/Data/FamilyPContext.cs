using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public DbSet<FamilyPromiseApp.Models.Referral> Referral { get; set; } = default!;
    }
}
