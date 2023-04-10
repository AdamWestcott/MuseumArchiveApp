using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<ArchivalItem> ArchivalItems { get; set; }
        public DbSet<Providences> Providences { get; set; }
        public DbSet<KeywordTag> KeywordTags { get; set; }

        public DbSet<KeywordTagGroup> KeywordTagGroups { get; set; }
    }
}
