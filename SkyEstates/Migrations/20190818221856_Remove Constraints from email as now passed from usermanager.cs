using Microsoft.EntityFrameworkCore.Migrations;

namespace SkyEstates.Migrations
{
    public partial class RemoveConstraintsfromemailasnowpassedfromusermanager : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Enquiries",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Enquiries",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
