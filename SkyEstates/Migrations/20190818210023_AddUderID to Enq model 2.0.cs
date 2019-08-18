using Microsoft.EntityFrameworkCore.Migrations;

namespace SkyEstates.Migrations
{
    public partial class AddUderIDtoEnqmodel20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Enquiries",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Enquiries",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
