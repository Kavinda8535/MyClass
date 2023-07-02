using ApplicationDomain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        // Define DbSet properties for your entities/tables
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        // Override OnModelCreating if needed
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure entity mappings, relationships, etc.
            // This method is optional and can be used if you need to customize the model configuration.
        }
    }
}
