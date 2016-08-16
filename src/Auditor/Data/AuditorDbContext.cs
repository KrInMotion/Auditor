using Auditor.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auditor.Data
{
    public class AuditorDbContext: DbContext
    {
        public DbSet<WifiCheck> WifiChecks { get; set; }

        public AuditorDbContext(DbContextOptions<AuditorDbContext> options): base(options)
        {
        }
    }
}
