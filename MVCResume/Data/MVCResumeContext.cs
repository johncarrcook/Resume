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
        public DbSet<MVCResume.Models.Achievement>? Achievement { get; set; }
        public DbSet<MVCResume.Models.Activity>? Activity { get; set; }
        public DbSet<MVCResume.Models.Education>? Education { get; set; }
        public DbSet<MVCResume.Models.Project>? Project { get; set; }
        public DbSet<MVCResume.Models.Skill>? Skill { get; set; }
        public DbSet<MVCResume.Models.Job>? Job { get; set; }

    }
}
