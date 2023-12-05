using CentumApps.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentumApps.Infastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Content> Contents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Content>().HasData(new Content
            {
                ContentId = 1,
                ContentTitle = "Report - 05/12/2023",
                ContentCategory = "Visual Management",
                ImageUrl = "https://placehold.co/600x400",
                CreatedBy = "Admin",
                IsActive = true,
            });
        }
    }
}
