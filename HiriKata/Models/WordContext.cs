using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HiriKata.Models
{
    public class WordDbContext : DbContext
    {
        public DbSet<Word> Words { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<PerfectGame> PerfectGames { get; set; }
    }
}