using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCResume.Models;

namespace MVCResume.Data
{
    public class MVCResumeContext : DbContext
    {
        public MVCResumeContext (DbContextOptions<MVCResumeContext> options)
            : base(options)
        {
        }

        public DbSet<MVCResume.Models.Resume>? Resume { get; set; }
        public DbSet<MVCResume.Models.Experience>? Experience { get; set; }
    }
}
