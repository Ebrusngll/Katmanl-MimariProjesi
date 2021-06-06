using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BitisTarihi",
                table: "Izinler");

            migrationBuilder.AlterColumn<int>(
                name: "SirketUyelikPlaniId",
                table: "Sirketler",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "IzinKullanilanGunSayisi",
                table: "Izinler",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "MesaiBaslangicTarihi",
                table: "Izinler",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SozlesmeBitisTarihi",
                table: "Calisanlar",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "SirketId",
                table: "Calisanlar",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MedeniDurum",
                table: "Calisanlar",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "KullaniciYorumuId",
                table: "Calisanlar",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "KanGrubu",
                table: "Calisanlar",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EngelDerecesi",
                table: "Calisanlar",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EgitimSeviyesi",
                table: "Calisanlar",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EgitimDurumu",
                table: "Calisanlar",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DogumTarihi",
                table: "Calisanlar",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "Cinsiyet",
                table: "Calisanlar",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BankaId",
                table: "Calisanlar",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BaglantiSosyalMedyaId",
                table: "Calisanlar",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AdresId",
                table: "Calisanlar",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AcilDurumBilgiID",
                table: "Calisanlar",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "KalanIzinSayisi",
                table: "Calisanlar",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KullandigiIzinSayisi",
                table: "Calisanlar",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "HarcamaTarihi",
                table: "CalisanHarcamalari",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "MyProperty",
                columns: table => new
                {
                    CalisanId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CalisanId1 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyProperty", x => x.CalisanId);
                    table.ForeignKey(
                        name: "FK_MyProperty_Calisanlar_CalisanId1",
                        column: x => x.CalisanId1,
                        principalTable: "Calisanlar",
                        principalColumn: "CalisanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EgitimBilgileri",
                columns: table => new
                {
                    EgitimBilgiId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    OkulAdi = table.Column<string>(nullable: true),
                    EgitimSeviyesi = table.Column<int>(nullable: false),
                    MezuniyetTarihi = table.Column<DateTime>(nullable: false),
                    CalisanId = table.Column<int>(nullable: false),
                    CalisanEgitimViewModelCalisanId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EgitimBilgileri", x => x.EgitimBilgiId);
                    table.ForeignKey(
                        name: "FK_EgitimBilgileri_MyProperty_CalisanEgitimViewModelCalisanId",
                        column: x => x.CalisanEgitimViewModelCalisanId,
                        principalTable: "MyProperty",
                        principalColumn: "CalisanId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EgitimBilgileri_Calisanlar_CalisanId",
                        column: x => x.CalisanId,
                        principalTable: "Calisanlar",
                        principalColumn: "CalisanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EgitimBilgileri_CalisanEgitimViewModelCalisanId",
                table: "EgitimBilgileri",
                column: "CalisanEgitimViewModelCalisanId");

            migrationBuilder.CreateIndex(
                name: "IX_EgitimBilgileri_CalisanId",
                table: "EgitimBilgileri",
                column: "CalisanId");

            migrationBuilder.CreateIndex(
                name: "IX_MyProperty_CalisanId1",
                table: "MyProperty",
                column: "CalisanId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EgitimBilgileri");

            migrationBuilder.DropTable(
                name: "MyProperty");

            migrationBuilder.DropColumn(
                name: "IzinKullanilanGunSayisi",
                table: "Izinler");

            migrationBuilder.DropColumn(
                name: "MesaiBaslangicTarihi",
                table: "Izinler");

            migrationBuilder.DropColumn(
                name: "KalanIzinSayisi",
                table: "Calisanlar");

            migrationBuilder.DropColumn(
                name: "KullandigiIzinSayisi",
                table: "Calisanlar");

            migrationBuilder.DropColumn(
                name: "HarcamaTarihi",
                table: "CalisanHarcamalari");

            migrationBuilder.AlterColumn<int>(
                name: "SirketUyelikPlaniId",
                table: "Sirketler",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BitisTarihi",
                table: "Izinler",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SozlesmeBitisTarihi",
                table: "Calisanlar",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SirketId",
                table: "Calisanlar",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MedeniDurum",
                table: "Calisanlar",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "KullaniciYorumuId",
                table: "Calisanlar",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "KanGrubu",
                table: "Calisanlar",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EngelDerecesi",
                table: "Calisanlar",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EgitimSeviyesi",
                table: "Calisanlar",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EgitimDurumu",
                table: "Calisanlar",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DogumTarihi",
                table: "Calisanlar",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Cinsiyet",
                table: "Calisanlar",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BankaId",
                table: "Calisanlar",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BaglantiSosyalMedyaId",
                table: "Calisanlar",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AdresId",
                table: "Calisanlar",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AcilDurumBilgiID",
                table: "Calisanlar",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
