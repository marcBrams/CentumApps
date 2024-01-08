using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CentumApps.Infastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddShiftReportsData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShiftReports",
                columns: table => new
                {
                    ReportId = table.Column<int>(type: "int", nullable: false),
                    ReportDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Team = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Area = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsSubmitted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShiftReports", x => x.ReportId);
                });

            migrationBuilder.InsertData(
                table: "ShiftReports",
                columns: new[] { "ReportId", "Area", "CreatedAt", "CreatedBy", "IsSubmitted", "ReportDate", "Status", "Team", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 1, "CDU", null, "Admin", false, "Report - 05/12/2023", "Draft", "A", null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShiftReports");
        }
    }
}
