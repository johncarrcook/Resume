using Microsoft.EntityFrameworkCore;
using MVCResume.Models;

namespace MVCResume.DataAccess
{
    public class MVCResumeContext : DbContext
    {
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<Experience> Experiences { get; set; }

        public string DbPath { get; }

        public MVCResumeContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "Resume.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

    }
}
