using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Todo.Core.Models;
using Todo.Data.Configurations;
using Todo.Data.Seeds;

namespace Todo.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Todos> Todos { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new TodosConfiguration());
            modelBuilder.ApplyConfiguration(new TodosSeed(new int[] { 1, 2, 3 }));
            modelBuilder.ApplyConfiguration(new UserSeed(new int[] { 1, 2, 3 }));
        }
    }
}
