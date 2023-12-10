using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FamilyPromiseApp.Migrations
{
    /// <inheritdoc />
    public partial class PersonReferral : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonID",
                table: "Referral",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SelectListGroup",
                columns: table => new
                {
                    Disabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateIndex(
                name: "IX_Referral_PersonID",
                table: "Referral",
                column: "PersonID");

            migrationBuilder.AddForeignKey(
                name: "FK_Referral_Person_PersonID",
                table: "Referral",
                column: "PersonID",
                principalTable: "Person",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Referral_Person_PersonID",
                table: "Referral");

            migrationBuilder.DropTable(
                name: "SelectListGroup");

            migrationBuilder.DropIndex(
                name: "IX_Referral_PersonID",
                table: "Referral");

            migrationBuilder.DropColumn(
                name: "PersonID",
                table: "Referral");
        }
    }
}
