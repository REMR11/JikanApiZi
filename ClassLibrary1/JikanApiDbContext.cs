using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class JikanApiDbContext : DbContext
    {

        public JikanApiDbContext() { }

        public JikanApiDbContext(DbContextOptions<JikanApiDbContext> options) : base(options) { }

        public DbSet<Anime> Animes { get; set; }

        /// <summary>
        /// Configuramos la conecion a base de datos
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=JikanDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Anime>(
                a =>
                {
                    a.HasKey(a => a.Id)
                    .HasName("pk__Anime");
                }
                );
        }

    }
}
