using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_instrumentation.Models
{
    public class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=D:\C#\DB_instrumentation\DB\app-test.db");
        }

        public DbSet<Categories> Categories { get; set; }
        public DbSet<Instuments> Instuments { get; set; }
        public DbSet<NoteImages> NoteImages { get; set; }
        public DbSet<Sounds> Sounds { get; set; }
        public DbSet<SoundsDatas> SoundsDatas { get; set; }
        public DbSet<Subinstuments> Subinstuments { get; set; }
        public DbSet<Subsounds> Subsounds { get; set; }
    }
}
