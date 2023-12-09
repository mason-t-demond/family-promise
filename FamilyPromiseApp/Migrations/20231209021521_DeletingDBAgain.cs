using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FamilyPromiseApp.Migrations
{
    /// <inheritdoc />
    public partial class DeletingDBAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IntakeModel",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    SubstanceIss = table.Column<string>(type: "TEXT", nullable: true),
                    TakenByNow = table.Column<string>(type: "TEXT", nullable: true),
                    TimeNow = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateToday = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Education = table.Column<string>(type: "TEXT", nullable: true),
                    TransportMethod = table.Column<string>(type: "TEXT", nullable: true),
                    ReferralAgency = table.Column<string>(type: "TEXT", nullable: true),
                    IsEmployed = table.Column<string>(type: "TEXT", nullable: true),
                    IsHoused = table.Column<string>(type: "TEXT", nullable: true),
                    Relationships = table.Column<string>(type: "TEXT", nullable: true),
                    WorkStudy = table.Column<string>(type: "TEXT", nullable: true),
                    AdultNum = table.Column<string>(type: "TEXT", nullable: true),
                    SSN = table.Column<int>(type: "INTEGER", nullable: false),
                    Reason = table.Column<int>(type: "INTEGER", nullable: false),
                    Reason2 = table.Column<int>(type: "INTEGER", nullable: false),
                    IDNum = table.Column<int>(type: "INTEGER", nullable: false),
                    Race = table.Column<string>(type: "TEXT", nullable: true),
                    Gender = table.Column<string>(type: "TEXT", nullable: true),
                    FirstName1 = table.Column<string>(type: "TEXT", nullable: true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    MaritalStatus = table.Column<string>(type: "TEXT", nullable: true),
                    ChildSchool = table.Column<string>(type: "TEXT", nullable: true),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    DateAdmitted = table.Column<int>(type: "INTEGER", nullable: false),
                    CompletionDate = table.Column<int>(type: "INTEGER", nullable: false),
                    DOB = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CellPhoneNum = table.Column<string>(type: "TEXT", nullable: true),
                    WorkPhoneNum = table.Column<string>(type: "TEXT", nullable: true),
                    EmailAdd = table.Column<string>(type: "TEXT", nullable: true),
                    HomeAddress = table.Column<string>(type: "TEXT", nullable: true),
                    HouseHoldMemberExists = table.Column<int>(type: "INTEGER", nullable: true),
                    AdultName = table.Column<string>(type: "TEXT", nullable: true),
                    AdultAge = table.Column<int>(type: "INTEGER", nullable: false),
                    AdultDateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AdultCellPhone = table.Column<string>(type: "TEXT", nullable: true),
                    AdultWorkPhone = table.Column<string>(type: "TEXT", nullable: true),
                    AdultEmail = table.Column<string>(type: "TEXT", nullable: true),
                    HouseHoldChildrenExists = table.Column<int>(type: "INTEGER", nullable: true),
                    RecentHousing = table.Column<int>(type: "INTEGER", nullable: true),
                    HouseType = table.Column<int>(type: "INTEGER", nullable: true),
                    ChildNum = table.Column<int>(type: "INTEGER", nullable: false),
                    ChildName = table.Column<string>(type: "TEXT", nullable: true),
                    ChildDateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ChildAge = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntakeModel", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IntakeModel");
        }
    }
}
