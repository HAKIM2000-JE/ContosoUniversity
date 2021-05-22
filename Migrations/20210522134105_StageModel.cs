using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContosoUniversity1.Migrations
{
    public partial class StageModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stage",
                columns: table => new
                {
                    StageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titre = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    debut = table.Column<DateTime>(nullable: false),
                    fin = table.Column<DateTime>(nullable: false),
                    etat = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stage", x => x.StageID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stage");
        }
    }
}
