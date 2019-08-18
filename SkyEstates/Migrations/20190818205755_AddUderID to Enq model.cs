using Microsoft.EntityFrameworkCore.Migrations;

namespace SkyEstates.Migrations
{
    public partial class AddUderIDtoEnqmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Enquiries",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Enquiries");
        }
    }
}
