using CentumApps.Domain.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CentumApps.Infastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Content> Contents { get; set; }
        public DbSet<ShiftReports> ShiftReports { get; set; }
        public DbSet<CDU_100> CDU { get; set; }

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

            modelBuilder.Entity<CDU_100>().HasData(new CDU_100
            {
                CDU_100_ID = 1,
                ShiftSupervisor = "Test",
                //ReportDate = 01-01-2023,
                Team = "A",
                ShiftTime = "08.00 - 17.00",
                DesignKapasitas = 1,
                Target = 1,
                Crude = 1,
                SRN = 1,
                Kerosene = 1,
                LGO = 1,
                HGO = 1,
                ResidueToTank = 1,
                ResidueToHVU = 1,
                ResidueTotal = 1,
                Cot100_H1 = 1,
                Cot100_H2 = 1,
                PressFZone = 1,
                PressTopT1 = 1,
                Press_100D1 = 1,
                TempBot = 1,
                TempTopT1 = 1,
                FlowSteam = 1,
                TempOutlet = 1,
                PressPassH1 = 1,
                PressPassE7 = 1,
                Util_PressSW = 1,
                Util_FlowSW = 1,
                Util_PressSteam = 1,
                Util_FlowSteam = 1,
                Util_PressCW = 1,
                Util_PressInstrumenAir = 1,
                Fuel_Gas = 1,
                Fuel_Oil = 1,
                Fuel_BFO_100H1 = 1,
                Fuel_BFG_100H1 = 1,
                Fuel_BPG_100H1 = 1,
                Fuel_BFO_100H2 = 1,
                Fuel_BFG_100H2 = 1,
                Fuel_BPG_100H2 = 1,
                Fuel_Clean_BFO_H1 = 1,
                Fuel_Clean_BFG_H1 = 1,
                Fuel_Clean_BPG_H1 = 1,
                Fuel_Amp_100_P6 = 1,
                Fuel_Amp_100_P9 = 1,
                Analisa_ColourHGO = 1,
                Analisa_RecHGO = 1,
                Analisa_FPKero = 1,
                Analisa_PHWaterboot = 1,
                Analisa_EPSRN = 1,
                KondisiKritis = "text",
                KondisiOperasi = "text",
                Pemeliharaan = "text",
                Notes_Manpower = 1,
                Notes_HT_Charger = 1,
                Notes_GasTester = 1,
                Notes_Sepeda = 1,
                Notes_MobilShift = 1,
                Notes_Stopwatch = 1,
                Notes_Calculator = 1,
                Notes_AirGalon = 1,
                Notes_Lembur = 1,
                Notes_HPBOC = 1,
                Notes_Oxymeter = 1,
                //CreatedAt =
                CreatedBy = "text",
                //UpdatedAt =
                UpdatedBy = "text",
                IsSubmitted = true
            });
        }
    }
}
