using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CalisanAvansID",
                table: "Calisanlar",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CalisanID",
                table: "CalisanAvanslar",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CalisanAvanslar_CalisanID",
                table: "CalisanAvanslar",
                column: "CalisanID");

            migrationBuilder.AddForeignKey(
                name: "FK_CalisanAvanslar_Calisanlar_CalisanID",
                table: "CalisanAvanslar",
                column: "CalisanID",
                principalTable: "Calisanlar",
                principalColumn: "CalisanId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CalisanAvanslar_Calisanlar_CalisanID",
                table: "CalisanAvanslar");

            migrationBuilder.DropIndex(
                name: "IX_CalisanAvanslar_CalisanID",
                table: "CalisanAvanslar");

            migrationBuilder.DropColumn(
                name: "CalisanAvansID",
                table: "Calisanlar");

            migrationBuilder.DropColumn(
                name: "CalisanID",
                table: "CalisanAvanslar");
        }
    }
}
