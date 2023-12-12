using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GlikoLog.DAL.Migrations
{
    /// <inheritdoc />
    public partial class yeni : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BesinDegerleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Karbonhidrat = table.Column<double>(type: "float", nullable: true),
                    Protein = table.Column<double>(type: "float", nullable: true),
                    Yag = table.Column<double>(type: "float", nullable: true),
                    Seker = table.Column<double>(type: "float", nullable: true),
                    Kalori = table.Column<double>(type: "float", nullable: true),
                    YemekId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BesinDegerleri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Egzersizler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EgzersizTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EgzersizSuresi = table.Column<int>(type: "int", nullable: false),
                    EgzersizTuru = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Egzersizler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IletisimBilgileri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Telefon = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IletisimBilgileri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ogunler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogunler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Yemekler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gorsel = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    BesinDegeriId = table.Column<int>(type: "int", nullable: true),
                    Porsiyon = table.Column<int>(type: "int", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yemekler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Yemekler_BesinDegerleri_BesinDegeriId",
                        column: x => x.BesinDegeriId,
                        principalTable: "BesinDegerleri",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yas = table.Column<int>(type: "int", nullable: false),
                    Kilo = table.Column<double>(type: "float", nullable: false),
                    Boy = table.Column<double>(type: "float", nullable: false),
                    Cinsiyet = table.Column<int>(type: "int", nullable: false),
                    IletisimBilgiId = table.Column<int>(type: "int", nullable: true),
                    KullaniciTuru = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kullanicilar_IletisimBilgileri_IletisimBilgiId",
                        column: x => x.IletisimBilgiId,
                        principalTable: "IletisimBilgileri",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "KullaniciEgzersizler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    egzersizId = table.Column<int>(type: "int", nullable: false),
                    kullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciEgzersizler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KullaniciEgzersizler_Egzersizler_egzersizId",
                        column: x => x.egzersizId,
                        principalTable: "Egzersizler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KullaniciEgzersizler_Kullanicilar_kullaniciId",
                        column: x => x.kullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KullaniciYemekleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    YemekId = table.Column<int>(type: "int", nullable: false),
                    OgunId = table.Column<int>(type: "int", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciYemekleri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KullaniciYemekleri_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KullaniciYemekleri_Ogunler_OgunId",
                        column: x => x.OgunId,
                        principalTable: "Ogunler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KullaniciYemekleri_Yemekler_YemekId",
                        column: x => x.YemekId,
                        principalTable: "Yemekler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SaglikBilgileri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    İlacAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IlacAdet = table.Column<int>(type: "int", nullable: true),
                    InsulinMi = table.Column<bool>(type: "bit", nullable: true),
                    KanSekeri = table.Column<double>(type: "float", nullable: true),
                    KullaniciId = table.Column<int>(type: "int", nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaglikBilgileri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SaglikBilgileri_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SuIcmeBilgileri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    MiktarMl = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuIcmeBilgileri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SuIcmeBilgileri_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kullanicilar",
                columns: new[] { "Id", "Ad", "Boy", "Cinsiyet", "Email", "IletisimBilgiId", "Kilo", "KullaniciTuru", "Sifre", "Soyad", "Yas" },
                values: new object[] { 1, "admin", 0.0, 0, "admin@bilgeadamboost.com", null, 0.0, 0, "8C6976E5B5410415BDE908BD4DEE15DFB167A9C873FC4BB8A81F6F2AB448A918", "admin", 0 });

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciEgzersizler_egzersizId",
                table: "KullaniciEgzersizler",
                column: "egzersizId");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciEgzersizler_kullaniciId",
                table: "KullaniciEgzersizler",
                column: "kullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicilar_Email",
                table: "Kullanicilar",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicilar_IletisimBilgiId",
                table: "Kullanicilar",
                column: "IletisimBilgiId",
                unique: true,
                filter: "[IletisimBilgiId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciYemekleri_KullaniciId",
                table: "KullaniciYemekleri",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciYemekleri_OgunId",
                table: "KullaniciYemekleri",
                column: "OgunId");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciYemekleri_YemekId",
                table: "KullaniciYemekleri",
                column: "YemekId");

            migrationBuilder.CreateIndex(
                name: "IX_SaglikBilgileri_KullaniciId",
                table: "SaglikBilgileri",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_SuIcmeBilgileri_KullaniciId",
                table: "SuIcmeBilgileri",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_Yemekler_BesinDegeriId",
                table: "Yemekler",
                column: "BesinDegeriId",
                unique: true,
                filter: "[BesinDegeriId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KullaniciEgzersizler");

            migrationBuilder.DropTable(
                name: "KullaniciYemekleri");

            migrationBuilder.DropTable(
                name: "SaglikBilgileri");

            migrationBuilder.DropTable(
                name: "SuIcmeBilgileri");

            migrationBuilder.DropTable(
                name: "Egzersizler");

            migrationBuilder.DropTable(
                name: "Ogunler");

            migrationBuilder.DropTable(
                name: "Yemekler");

            migrationBuilder.DropTable(
                name: "Kullanicilar");

            migrationBuilder.DropTable(
                name: "BesinDegerleri");

            migrationBuilder.DropTable(
                name: "IletisimBilgileri");
        }
    }
}
