﻿// <auto-generated />
using System;
using CentumApps.Infastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CentumApps.Infastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CentumApps.Domain.Entities.CDU_100", b =>
                {
                    b.Property<int>("CDU_100_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CDU_100_ID"));

                    b.Property<int?>("Analisa_EP_Kero")
                        .HasColumnType("int");

                    b.Property<int?>("Analisa_EP_SRN")
                        .HasColumnType("int");

                    b.Property<int?>("Analisa_FP_Kero")
                        .HasColumnType("int");

                    b.Property<int?>("Analisa_HGO")
                        .HasColumnType("int");

                    b.Property<int?>("Analisa_LGO")
                        .HasColumnType("int");

                    b.Property<int?>("Analisa_PHWater_Boot")
                        .HasColumnType("int");

                    b.Property<int?>("Analisa_Rec_HGO")
                        .HasColumnType("int");

                    b.Property<int?>("Cot100_H1")
                        .HasColumnType("int");

                    b.Property<int?>("Cot100_H2")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Crude")
                        .HasColumnType("int");

                    b.Property<int?>("DesignKapasitas")
                        .HasColumnType("int");

                    b.Property<int?>("FlowSteam")
                        .HasColumnType("int");

                    b.Property<int?>("Fuel_Amp_100_P6")
                        .HasColumnType("int");

                    b.Property<int?>("Fuel_Amp_100_P9")
                        .HasColumnType("int");

                    b.Property<int?>("Fuel_BFG_100H1")
                        .HasColumnType("int");

                    b.Property<int?>("Fuel_BFG_100H2")
                        .HasColumnType("int");

                    b.Property<int?>("Fuel_BFO_100H1")
                        .HasColumnType("int");

                    b.Property<int?>("Fuel_BFO_100H2")
                        .HasColumnType("int");

                    b.Property<int?>("Fuel_BPG_100H1")
                        .HasColumnType("int");

                    b.Property<int?>("Fuel_BPG_100H2")
                        .HasColumnType("int");

                    b.Property<int?>("Fuel_Clean_BFG_H1")
                        .HasColumnType("int");

                    b.Property<int?>("Fuel_Clean_BFO_H1")
                        .HasColumnType("int");

                    b.Property<int?>("Fuel_Clean_BPG_H1")
                        .HasColumnType("int");

                    b.Property<int?>("Fuel_Gas")
                        .HasColumnType("int");

                    b.Property<int?>("Fuel_Oil")
                        .HasColumnType("int");

                    b.Property<int?>("HGO")
                        .HasColumnType("int");

                    b.Property<bool?>("IsSubmitted")
                        .HasColumnType("bit");

                    b.Property<int?>("Kerosene")
                        .HasColumnType("int");

                    b.Property<string>("KondisiKritis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KondisiOperasi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LGO")
                        .HasColumnType("int");

                    b.Property<int?>("Notes_AirGalonKosong")
                        .HasColumnType("int");

                    b.Property<int?>("Notes_AirGalonPenuh")
                        .HasColumnType("int");

                    b.Property<int?>("Notes_Battery")
                        .HasColumnType("int");

                    b.Property<int?>("Notes_Calculator")
                        .HasColumnType("int");

                    b.Property<int?>("Notes_Charger")
                        .HasColumnType("int");

                    b.Property<int?>("Notes_Dymo")
                        .HasColumnType("int");

                    b.Property<int?>("Notes_GasTester")
                        .HasColumnType("int");

                    b.Property<int?>("Notes_HPBOC")
                        .HasColumnType("int");

                    b.Property<int?>("Notes_HT")
                        .HasColumnType("int");

                    b.Property<string>("Notes_Lembur")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Notes_Manpower")
                        .HasColumnType("int");

                    b.Property<int?>("Notes_MobilShift")
                        .HasColumnType("int");

                    b.Property<string>("Notes_MobilShiftCondition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Notes_Oxymeter")
                        .HasColumnType("int");

                    b.Property<int?>("Notes_Sepeda")
                        .HasColumnType("int");

                    b.Property<int?>("Notes_Stopwatch")
                        .HasColumnType("int");

                    b.Property<int?>("Notes_Tensimeter")
                        .HasColumnType("int");

                    b.Property<string>("Pemeliharaan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PressFZone")
                        .HasColumnType("int");

                    b.Property<int?>("PressPassE7")
                        .HasColumnType("int");

                    b.Property<int?>("PressPassH1")
                        .HasColumnType("int");

                    b.Property<int?>("PressTopT1")
                        .HasColumnType("int");

                    b.Property<int?>("Press_100D1")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ReportDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ResidueToHVU")
                        .HasColumnType("int");

                    b.Property<int?>("ResidueToTank")
                        .HasColumnType("int");

                    b.Property<int?>("ResidueTotal")
                        .HasColumnType("int");

                    b.Property<int?>("SRN")
                        .HasColumnType("int");

                    b.Property<string>("ShiftSupervisor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShiftTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Target")
                        .HasColumnType("int");

                    b.Property<string>("Team")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TempBot")
                        .HasColumnType("int");

                    b.Property<int?>("TempOutlet")
                        .HasColumnType("int");

                    b.Property<int?>("TempTopT1")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Util_FlowSW")
                        .HasColumnType("int");

                    b.Property<int?>("Util_FlowSteam")
                        .HasColumnType("int");

                    b.Property<int?>("Util_PressCW")
                        .HasColumnType("int");

                    b.Property<int?>("Util_PressInstrumenAir")
                        .HasColumnType("int");

                    b.Property<int?>("Util_PressSW")
                        .HasColumnType("int");

                    b.Property<int?>("Util_PressSteam")
                        .HasColumnType("int");

                    b.HasKey("CDU_100_ID");

                    b.ToTable("CDU");

                    b.HasData(
                        new
                        {
                            CDU_100_ID = 1,
                            Analisa_EP_Kero = 1,
                            Analisa_EP_SRN = 1,
                            Analisa_FP_Kero = 1,
                            Analisa_HGO = 1,
                            Analisa_LGO = 1,
                            Analisa_PHWater_Boot = 1,
                            Analisa_Rec_HGO = 1,
                            Cot100_H1 = 1,
                            Cot100_H2 = 1,
                            CreatedBy = "text",
                            Crude = 1,
                            DesignKapasitas = 1,
                            FlowSteam = 1,
                            Fuel_Amp_100_P6 = 1,
                            Fuel_Amp_100_P9 = 1,
                            Fuel_BFG_100H1 = 1,
                            Fuel_BFG_100H2 = 1,
                            Fuel_BFO_100H1 = 1,
                            Fuel_BFO_100H2 = 1,
                            Fuel_BPG_100H1 = 1,
                            Fuel_BPG_100H2 = 1,
                            Fuel_Clean_BFG_H1 = 1,
                            Fuel_Clean_BFO_H1 = 1,
                            Fuel_Clean_BPG_H1 = 1,
                            Fuel_Gas = 1,
                            Fuel_Oil = 1,
                            HGO = 1,
                            IsSubmitted = true,
                            Kerosene = 1,
                            KondisiKritis = "text",
                            KondisiOperasi = "text",
                            LGO = 1,
                            Notes_AirGalonKosong = 1,
                            Notes_AirGalonPenuh = 1,
                            Notes_Battery = 1,
                            Notes_Calculator = 1,
                            Notes_Charger = 1,
                            Notes_Dymo = 1,
                            Notes_GasTester = 1,
                            Notes_HPBOC = 1,
                            Notes_HT = 1,
                            Notes_Lembur = "test",
                            Notes_Manpower = 1,
                            Notes_MobilShift = 1,
                            Notes_MobilShiftCondition = "good",
                            Notes_Oxymeter = 1,
                            Notes_Sepeda = 1,
                            Notes_Stopwatch = 1,
                            Notes_Tensimeter = 1,
                            Pemeliharaan = "text",
                            PressFZone = 1,
                            PressPassE7 = 1,
                            PressPassH1 = 1,
                            PressTopT1 = 1,
                            Press_100D1 = 1,
                            ResidueToHVU = 1,
                            ResidueToTank = 1,
                            ResidueTotal = 1,
                            SRN = 1,
                            ShiftSupervisor = "Test",
                            ShiftTime = "08.00 - 17.00",
                            Target = 1,
                            Team = "A",
                            TempBot = 1,
                            TempOutlet = 1,
                            TempTopT1 = 1,
                            UpdatedBy = "text",
                            Util_FlowSW = 1,
                            Util_FlowSteam = 1,
                            Util_PressCW = 1,
                            Util_PressInstrumenAir = 1,
                            Util_PressSW = 1,
                            Util_PressSteam = 1
                        });
                });

            modelBuilder.Entity("CentumApps.Domain.Entities.Content", b =>
                {
                    b.Property<int>("ContentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContentId"));

                    b.Property<string>("ContentCategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContentDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContentTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("ContentId");

                    b.ToTable("Contents");

                    b.HasData(
                        new
                        {
                            ContentId = 1,
                            ContentCategory = "Visual Management",
                            ContentTitle = "Report - 05/12/2023",
                            CreatedBy = "Admin",
                            ImageUrl = "https://placehold.co/600x400",
                            IsActive = true
                        });
                });

            modelBuilder.Entity("CentumApps.Domain.Entities.ShiftReports", b =>
                {
                    b.Property<int>("ReportId")
                        .HasColumnType("int");

                    b.Property<string>("Area")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsSubmitted")
                        .HasColumnType("bit");

                    b.Property<string>("ReportDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Team")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReportId");

                    b.ToTable("ShiftReports");

                    b.HasData(
                        new
                        {
                            ReportId = 1,
                            Area = "CDU",
                            CreatedBy = "Admin",
                            IsSubmitted = false,
                            ReportDate = "Report - 05/12/2023",
                            Status = "Draft",
                            Team = "A"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
