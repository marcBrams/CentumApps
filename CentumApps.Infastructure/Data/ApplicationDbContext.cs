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
        public DbSet<ShiftReports> ShiftReports { get; set; }

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

            modelBuilder.Entity<ShiftReports>().HasData(new ShiftReports
            {
                ReportId = 1,
                ReportDate = "Report - 05/12/2023",
                Status = "Draft",
                Team = "A",
                Area = "CDU",
                CreatedBy = "Admin",
                IsSubmitted = false,

            });
        }
    }
}
