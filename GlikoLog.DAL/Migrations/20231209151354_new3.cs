using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GlikoLog.DAL.Migrations
{
    /// <inheritdoc />
    public partial class new3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KullaniciEgzersizler_Egzersizler_egzersizId",
                table: "KullaniciEgzersizler");

            migrationBuilder.RenameColumn(
                name: "egzersizId",
                table: "KullaniciEgzersizler",
                newName: "EgzersizId");

            migrationBuilder.RenameIndex(
                name: "IX_KullaniciEgzersizler_egzersizId",
                table: "KullaniciEgzersizler",
                newName: "IX_KullaniciEgzersizler_EgzersizId");

            migrationBuilder.AddForeignKey(
                name: "FK_KullaniciEgzersizler_Egzersizler_EgzersizId",
                table: "KullaniciEgzersizler",
                column: "EgzersizId",
                principalTable: "Egzersizler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KullaniciEgzersizler_Egzersizler_EgzersizId",
                table: "KullaniciEgzersizler");

            migrationBuilder.RenameColumn(
                name: "EgzersizId",
                table: "KullaniciEgzersizler",
                newName: "egzersizId");

            migrationBuilder.RenameIndex(
                name: "IX_KullaniciEgzersizler_EgzersizId",
                table: "KullaniciEgzersizler",
                newName: "IX_KullaniciEgzersizler_egzersizId");

            migrationBuilder.AddForeignKey(
                name: "FK_KullaniciEgzersizler_Egzersizler_egzersizId",
                table: "KullaniciEgzersizler",
                column: "egzersizId",
                principalTable: "Egzersizler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
