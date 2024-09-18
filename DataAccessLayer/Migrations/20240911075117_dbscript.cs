using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class dbscript : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CricketerDetail",
                columns: table => new
                {
                    CricketersID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CricketerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Totalinnings = table.Column<long>(type: "bigint", nullable: false),
                    TotalScore = table.Column<long>(type: "bigint", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumberOfFifties = table.Column<long>(type: "bigint", nullable: false),
                    NumberOfHundreds = table.Column<long>(type: "bigint", nullable: false),
                    HighestScore = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CricketerDetail", x => x.CricketersID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CricketerDetail");
        }
    }
}
