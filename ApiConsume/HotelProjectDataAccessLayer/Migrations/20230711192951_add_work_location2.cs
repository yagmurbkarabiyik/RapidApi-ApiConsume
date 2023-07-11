using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelProjectDataAccessLayer.Migrations
{
    public partial class add_work_location2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WorkLocationCity",
                table: "WorkLocations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WorkLocationCity",
                table: "WorkLocations");
        }
    }
}
