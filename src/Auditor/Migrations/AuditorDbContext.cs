using Auditor.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auditor.Data
{
    public class AuditorDbContext: IdentityDbContext<AppUser>
    {
        public DbSet<WifiCheck> WifiChecks { get; set; }
        public DbSet<AuditorUser> AuditorUsers { get; set; }
        public DbSet<Territory> Territories { get; set; }

        public AuditorDbContext(DbContextOptions<AuditorDbContext> options): base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<WifiCheck>(entity =>
                {
                    entity.Property(x => x.Address).IsRequired().HasMaxLength(255);
                    entity.Property(x => x.Provider).IsRequired().HasMaxLength(255);
                    entity.Property(x => x.CreatedAt).HasDefaultValueSql("getdate()");
                });
            builder.Entity<Territory>(entity =>
            {
                entity.Property(x => x.Region).IsRequired().HasMaxLength(255);
                entity.Property(x => x.Capital).HasMaxLength(255);
            });
        }
    }
}
