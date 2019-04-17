using Microsoft.EntityFrameworkCore.Migrations;

namespace Events.Infra.Data.Migrations
{
    public partial class LastUpdateEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShortDescrition",
                table: "Events",
                newName: "ShortDescription");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShortDescription",
                table: "Events",
                newName: "ShortDescrition");
        }
    }
}
