using Football.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Data
{
   public class FootballContext : DbContext
    {
        public FootballContext() : base("Default") { }

        public FootballContext(string connectionString) : base(connectionString)
        {
        }
        public DbSet<Cards> Cards { get; set; }
        public DbSet<Matches> Matches { get; set; }
        public DbSet<Players> Players { get; set; }
    }
}
