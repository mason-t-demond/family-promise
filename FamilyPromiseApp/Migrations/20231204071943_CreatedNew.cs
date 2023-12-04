using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FamilyPromiseApp.Migrations
{
    /// <inheritdoc />
    public partial class CreatedNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_Case_CaseID",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Person_CaseID",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "CaseID",
                table: "Person");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CaseID",
                table: "Person",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Person_CaseID",
                table: "Person",
                column: "CaseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Case_CaseID",
                table: "Person",
                column: "CaseID",
                principalTable: "Case",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
