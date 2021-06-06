using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class Avans : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sirket",
                table: "CalisanKariyerler");

            migrationBuilder.AddColumn<string>(
                name: "GorevTanimi",
                table: "CalisanKariyerler",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YetenekTanimi",
                table: "CalisanKariyerler",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TaksitSayısı",
                table: "CalisanAvanslar",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "AvansMiktarı",
                table: "CalisanAvanslar",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "AvansOnaylandıgıTarih",
                table: "CalisanAvanslar",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "AvansTalepEdilenTarih",
                table: "CalisanAvanslar",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "AvansVerildigiTarih",
                table: "CalisanAvanslar",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "OnaylandiMi",
                table: "CalisanAvanslar",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GorevTanimi",
                table: "CalisanKariyerler");

            migrationBuilder.DropColumn(
                name: "YetenekTanimi",
                table: "CalisanKariyerler");

            migrationBuilder.DropColumn(
                name: "AvansOnaylandıgıTarih",
                table: "CalisanAvanslar");

            migrationBuilder.DropColumn(
                name: "AvansTalepEdilenTarih",
                table: "CalisanAvanslar");

            migrationBuilder.DropColumn(
                name: "AvansVerildigiTarih",
                table: "CalisanAvanslar");

            migrationBuilder.DropColumn(
                name: "OnaylandiMi",
                table: "CalisanAvanslar");

            migrationBuilder.AddColumn<string>(
                name: "Sirket",
                table: "CalisanKariyerler",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TaksitSayısı",
                table: "CalisanAvanslar",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AvansMiktarı",
                table: "CalisanAvanslar",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
