using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoderUL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ElectricityConsumers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    User = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricityConsumers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Counter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateOfAcceptance = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StateVerificationPeriod = table.Column<uint>(type: "INTEGER", nullable: false),
                    ElectricityConsumerId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Counter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Counter_ElectricityConsumers_ElectricityConsumerId",
                        column: x => x.ElectricityConsumerId,
                        principalTable: "ElectricityConsumers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HistoryIndications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Indications = table.Column<uint>(type: "INTEGER", nullable: false),
                    CounterId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryIndications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoryIndications_Counter_CounterId",
                        column: x => x.CounterId,
                        principalTable: "Counter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Counter_ElectricityConsumerId",
                table: "Counter",
                column: "ElectricityConsumerId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryIndications_CounterId",
                table: "HistoryIndications",
                column: "CounterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoryIndications");

            migrationBuilder.DropTable(
                name: "Counter");

            migrationBuilder.DropTable(
                name: "ElectricityConsumers");
        }
    }
}
