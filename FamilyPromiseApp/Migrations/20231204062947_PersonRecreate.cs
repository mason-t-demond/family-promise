using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FamilyPromiseApp.Migrations
{
    /// <inheritdoc />
    public partial class PersonRecreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Case",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TakenBy = table.Column<string>(type: "TEXT", nullable: true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Time = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ReferringAgency = table.Column<string>(type: "TEXT", nullable: true),
                    CurrentSituation = table.Column<string>(type: "TEXT", nullable: true),
                    IsHoused = table.Column<string>(type: "TEXT", nullable: true),
                    IsEmployed = table.Column<string>(type: "TEXT", nullable: true),
                    TransportMethod = table.Column<string>(type: "TEXT", nullable: true),
                    Substance = table.Column<string>(type: "TEXT", nullable: true),
                    HealthChallenge = table.Column<string>(type: "TEXT", nullable: true),
                    DomesticViolenceHistory = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Case", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CaseID = table.Column<int>(type: "INTEGER", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CellPhone = table.Column<string>(type: "TEXT", nullable: true),
                    WorkPhone = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    HouseHoldMemberExist = table.Column<int>(type: "INTEGER", nullable: true),
                    HouseHoldNum = table.Column<int>(type: "INTEGER", nullable: false),
                    AdultName = table.Column<string>(type: "TEXT", nullable: true),
                    AdultAge = table.Column<int>(type: "INTEGER", nullable: false),
                    AdultDateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AdultCellPhone = table.Column<string>(type: "TEXT", nullable: true),
                    AdultWorkPhone = table.Column<string>(type: "TEXT", nullable: true),
                    AdultEmail = table.Column<string>(type: "TEXT", nullable: true),
                    HouseHoldChildrenExist = table.Column<int>(type: "INTEGER", nullable: true),
                    ChildName = table.Column<string>(type: "TEXT", nullable: true),
                    ChildDateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ChildAge = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Person_Case_CaseID",
                        column: x => x.CaseID,
                        principalTable: "Case",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Person_CaseID",
                table: "Person",
                column: "CaseID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Case");
        }
    }
}
