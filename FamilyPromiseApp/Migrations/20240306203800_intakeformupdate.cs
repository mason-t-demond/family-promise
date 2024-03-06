using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FamilyPromiseApp.Migrations
{
    /// <inheritdoc />
    public partial class intakeformupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReferralAgency",
                table: "IntakeModel");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdmitted",
                table: "IntakeModel",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CompletionDate",
                table: "IntakeModel",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "ReferralAgencyID",
                table: "IntakeModel",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_IntakeModel_ReferralAgencyID",
                table: "IntakeModel",
                column: "ReferralAgencyID");

            migrationBuilder.AddForeignKey(
                name: "FK_IntakeModel_Referral_ReferralAgencyID",
                table: "IntakeModel",
                column: "ReferralAgencyID",
                principalTable: "Referral",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IntakeModel_Referral_ReferralAgencyID",
                table: "IntakeModel");

            migrationBuilder.DropIndex(
                name: "IX_IntakeModel_ReferralAgencyID",
                table: "IntakeModel");

            migrationBuilder.DropColumn(
                name: "ReferralAgencyID",
                table: "IntakeModel");

            migrationBuilder.AlterColumn<int>(
                name: "DateAdmitted",
                table: "IntakeModel",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CompletionDate",
                table: "IntakeModel",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReferralAgency",
                table: "IntakeModel",
                type: "TEXT",
                nullable: true);
        }
    }
}
