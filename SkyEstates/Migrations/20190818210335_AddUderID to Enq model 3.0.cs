using Microsoft.EntityFrameworkCore.Migrations;

namespace SkyEstates.Migrations
{
    public partial class AddUderIDtoEnqmodel30 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HouseId",
                table: "Enquiries");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Enquiries",
                nullable: true,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Enquiries",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HouseId",
                table: "Enquiries",
                nullable: false,
                defaultValue: 0);
        }
    }
}
