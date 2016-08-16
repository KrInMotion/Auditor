using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auditor.Data
{
    public class AuditorDbContext: DbContext
    {
        public AuditorDbContext(DbContextOptions<AuditorDbContext> options): base(options)
        {

        }
    }
}
