using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class Filtre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EgitimBilgileri_MyProperty_CalisanEgitimViewModelCalisanId",
                table: "EgitimBilgileri");

            migrationBuilder.DropForeignKey(
                name: "FK_MyProperty_Calisanlar_CalisanId1",
                table: "MyProperty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyProperty",
                table: "MyProperty");

            migrationBuilder.DropColumn(
                name: "KalanIzinSayisi",
                table: "Calisanlar");

            migrationBuilder.DropColumn(
                name: "KullandigiIzinSayisi",
                table: "Calisanlar");

            migrationBuilder.RenameTable(
                name: "MyProperty",
                newName: "CalisanEgitim");

            migrationBuilder.RenameIndex(
                name: "IX_MyProperty_CalisanId1",
                table: "CalisanEgitim",
                newName: "IX_CalisanEgitim_CalisanId1");

            migrationBuilder.AlterColumn<int>(
                name: "CalisanAvansID",
                table: "Calisanlar",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "KalanYıllıkIzinSayisi",
                table: "Calisanlar",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KullandigiYıllıkIzinSayisi",
                table: "Calisanlar",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ToplamKullanilanIzinSayisi",
                table: "Calisanlar",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CalisanId1",
                table: "CalisanEgitim",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CalisanEgitim",
                table: "CalisanEgitim",
                column: "CalisanId");

            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mail = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CalisanEgitim_Calisanlar_CalisanId1",
                table: "CalisanEgitim",
                column: "CalisanId1",
                principalTable: "Calisanlar",
                principalColumn: "CalisanId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EgitimBilgileri_CalisanEgitim_CalisanEgitimViewModelCalisanId",
                table: "EgitimBilgileri",
                column: "CalisanEgitimViewModelCalisanId",
                principalTable: "CalisanEgitim",
                principalColumn: "CalisanId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CalisanEgitim_Calisanlar_CalisanId1",
                table: "CalisanEgitim");

            migrationBuilder.DropForeignKey(
                name: "FK_EgitimBilgileri_CalisanEgitim_CalisanEgitimViewModelCalisanId",
                table: "EgitimBilgileri");

            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CalisanEgitim",
                table: "CalisanEgitim");

            migrationBuilder.DropColumn(
                name: "KalanYıllıkIzinSayisi",
                table: "Calisanlar");

            migrationBuilder.DropColumn(
                name: "KullandigiYıllıkIzinSayisi",
                table: "Calisanlar");

            migrationBuilder.DropColumn(
                name: "ToplamKullanilanIzinSayisi",
                table: "Calisanlar");

            migrationBuilder.RenameTable(
                name: "CalisanEgitim",
                newName: "MyProperty");

            migrationBuilder.RenameIndex(
                name: "IX_CalisanEgitim_CalisanId1",
                table: "MyProperty",
                newName: "IX_MyProperty_CalisanId1");

            migrationBuilder.AlterColumn<int>(
                name: "CalisanAvansID",
                table: "Calisanlar",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KalanIzinSayisi",
                table: "Calisanlar",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KullandigiIzinSayisi",
                table: "Calisanlar",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CalisanId1",
                table: "MyProperty",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyProperty",
                table: "MyProperty",
                column: "CalisanId");

            migrationBuilder.AddForeignKey(
                name: "FK_EgitimBilgileri_MyProperty_CalisanEgitimViewModelCalisanId",
                table: "EgitimBilgileri",
                column: "CalisanEgitimViewModelCalisanId",
                principalTable: "MyProperty",
                principalColumn: "CalisanId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MyProperty_Calisanlar_CalisanId1",
                table: "MyProperty",
                column: "CalisanId1",
                principalTable: "Calisanlar",
                principalColumn: "CalisanId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
