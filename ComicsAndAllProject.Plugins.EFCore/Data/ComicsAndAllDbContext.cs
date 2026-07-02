using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicsAndAllProject.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace ComicsAndAllProject.Plugins.EFCore.Data
{
    public class ComicsAndAllDbContext : DbContext
    {
       public ComicsAndAllDbContext(DbContextOptions<ComicsAndAllDbContext> options): base(options)
        {
        }

        public DbSet<Character> Characters { get; set; }

        public DbSet<Creator> Creators { get; set; }

        public DbSet<Issue> Issues { get; set; }

        public DbSet<Publisher> Publishers { get; set; }

        public DbSet<Series> Series { get; set; }

        public DbSet<Volume> Volumes { get; set; }

        public DbSet<FavoriteCharacter> FavoriteCharacters { get; set; }

        public DbSet<UserProfile> UserProfiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserProfile>()
                .Ignore(userProfile => userProfile.FavoriteCharacters);
        }
    }
}
