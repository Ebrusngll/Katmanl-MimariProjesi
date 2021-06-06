using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class newww : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OnayRedDurumu",
                table: "Izinler");

            migrationBuilder.DropColumn(
                name: "OnaylandiMi",
                table: "CalisanAvanslar");

            migrationBuilder.AddColumn<int>(
                name: "OnayDurumu",
                table: "Izinler",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RedAcıklaması",
                table: "Izinler",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OnayDurumu",
                table: "CalisanHarcamalari",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RedAcıklaması",
                table: "CalisanHarcamalari",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "AvansMiktarı",
                table: "CalisanAvanslar",
                type: "decimal",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<int>(
                name: "OnayDurumu",
                table: "CalisanAvanslar",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RedAciklama",
                table: "CalisanAvanslar",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Sablonlar",
                columns: table => new
                {
                    SablonId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Baslik = table.Column<string>(maxLength: 100, nullable: false),
                    Icerik = table.Column<string>(maxLength: 500, nullable: false),
                    SablonTanimi = table.Column<int>(nullable: false),
                    SablonGorselYolu = table.Column<string>(nullable: true),
                    ArkaPlanRengi = table.Column<string>(nullable: true),
                    GonderilecekMi = table.Column<bool>(nullable: false),
                    CalisanId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sablonlar", x => x.SablonId);
                    table.ForeignKey(
                        name: "FK_Sablonlar_Calisanlar_CalisanId",
                        column: x => x.CalisanId,
                        principalTable: "Calisanlar",
                        principalColumn: "CalisanId");
                });

            migrationBuilder.CreateTable(
                name: "Bildirimler",
                columns: table => new
                {
                    BildirimId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    SablonId = table.Column<int>(nullable: false),
                    CalisanId = table.Column<int>(nullable: false),
                    OkunduMu = table.Column<bool>(nullable: false),
                    OkunmaTarihi = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bildirimler", x => x.BildirimId);
                    table.ForeignKey(
                        name: "FK_Bildirimler_Calisanlar_CalisanId",
                        column: x => x.CalisanId,
                        principalTable: "Calisanlar",
                        principalColumn: "CalisanId");
                    table.ForeignKey(
                        name: "FK_Bildirimler_Sablonlar_SablonId",
                        column: x => x.SablonId,
                        principalTable: "Sablonlar",
                        principalColumn: "SablonId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bildirimler_CalisanId",
                table: "Bildirimler",
                column: "CalisanId");

            migrationBuilder.CreateIndex(
                name: "IX_Bildirimler_SablonId",
                table: "Bildirimler",
                column: "SablonId");

            migrationBuilder.CreateIndex(
                name: "IX_Sablonlar_CalisanId",
                table: "Sablonlar",
                column: "CalisanId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bildirimler");

            migrationBuilder.DropTable(
                name: "Sablonlar");

            migrationBuilder.DropColumn(
                name: "OnayDurumu",
                table: "Izinler");

            migrationBuilder.DropColumn(
                name: "RedAcıklaması",
                table: "Izinler");

            migrationBuilder.DropColumn(
                name: "OnayDurumu",
                table: "CalisanHarcamalari");

            migrationBuilder.DropColumn(
                name: "RedAcıklaması",
                table: "CalisanHarcamalari");

            migrationBuilder.DropColumn(
                name: "OnayDurumu",
                table: "CalisanAvanslar");

            migrationBuilder.DropColumn(
                name: "RedAciklama",
                table: "CalisanAvanslar");

            migrationBuilder.AddColumn<bool>(
                name: "OnayRedDurumu",
                table: "Izinler",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<decimal>(
                name: "AvansMiktarı",
                table: "CalisanAvanslar",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal");

            migrationBuilder.AddColumn<bool>(
                name: "OnaylandiMi",
                table: "CalisanAvanslar",
                type: "bit",
                nullable: true);
        }
    }
}
