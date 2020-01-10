using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace AppWebSite.Migrations
{
    public partial class MigrationDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "encuesta",
                columns: table => new
                {
                    enfecha = table.Column<DateTime>(type: "date", nullable: false),
                    enemail = table.Column<string>(unicode: false, maxLength: 250, nullable: false),
                    ennombre = table.Column<string>(unicode: false, maxLength: 250, nullable: false),
                    encalificacion = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_encuesta", x => new { x.enfecha, x.enemail });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "encuesta");
        }
    }
}
