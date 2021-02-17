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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Players>()
                .Property(x => x.NamePlayer)
                .HasMaxLength(100);

            modelBuilder.Entity<Players>()
                .HasIndex(x => x.NamePlayer)
                .IsUnique();

            modelBuilder.Entity<Cards>()
                .HasMany(x => x.Players)
                .WithMany(x => x.Cards);
        }
    }
}
