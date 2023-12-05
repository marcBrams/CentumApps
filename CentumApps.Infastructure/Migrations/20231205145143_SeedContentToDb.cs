using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CentumApps.Infastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedContentToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isActive",
                table: "Contents",
                newName: "IsActive");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Contents",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "ContentId", "ContentCategory", "ContentTitle", "CreatedAt", "CreatedBy", "ImageUrl", "IsActive", "UpdatedAt" },
                values: new object[] { 1, "Visual Management", "Report - 05/12/2023", null, "Admin", "https://placehold.co/600x400", true, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Contents",
                newName: "isActive");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Contents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
