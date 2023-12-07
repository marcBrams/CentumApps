using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CentumApps.Infastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddDescriptionToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContentDescription",
                table: "Contents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 1,
                column: "ContentDescription",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContentDescription",
                table: "Contents");
        }
    }
}
