using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using children_of_devin_back_end.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace children_of_devin_back_end.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Need> Needs { get; set; }

        public DbSet<Person> People { get; set; }

        public DbSet<Story> Stories { get; set; }

        public DbSet<Suggestion> Suggestions { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Need>()
                .HasOne(n => n.Person)
                .WithMany(p => p.Needs)
                .HasForeignKey(n => n.PersonId);

            modelBuilder.Entity<Story>()
                .HasOne(s => s.Author)
                .WithMany(а => а.Stories)
                .HasForeignKey(s => s.AuthorId);

            modelBuilder.Entity<Suggestion>()
                .HasOne(s => s.Need)
                .WithMany(n => n.Suggestions)
                .HasForeignKey(s => s.NeedId);
        }
    }
}
