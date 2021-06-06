﻿// <auto-generated />
using System;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(KolayIkContext))]
    [Migration("20210429191951_new")]
    partial class @new
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataAccess.ViewModels.CalisanEgitimViewModel", b =>
                {
                    b.Property<int>("CalisanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CalisanId1")
                        .HasColumnType("int");

                    b.HasKey("CalisanId");

                    b.HasIndex("CalisanId1");

                    b.ToTable("MyProperty");
                });

            modelBuilder.Entity("Entities.Concrete.AcilDurumBilgi", b =>
                {
                    b.Property<int>("AcilDurumBilgiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AranacakKisiAd")
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("AranacakKisiSoyad")
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<int>("CalisanId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TelefonNo")
                        .HasColumnType("nvarchar(13)")
                        .HasMaxLength(13);

                    b.Property<string>("YakinlikDerecesi")
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.HasKey("AcilDurumBilgiId");

                    b.HasIndex("CalisanId")
                        .IsUnique();

                    b.ToTable("AcilDurumBilgileri");
                });

            modelBuilder.Entity("Entities.Concrete.Adres", b =>
                {
                    b.Property<int>("AdresId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdresAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdresDevam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CalisanID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EvTelefonu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PostaKodu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sehir")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ulke")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdresId");

                    b.HasIndex("CalisanID")
                        .IsUnique();

                    b.ToTable("Adresler");
                });

            modelBuilder.Entity("Entities.Concrete.BaglantiSosyalMedya", b =>
                {
                    b.Property<int>("BaglantiSosyalMedyaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BaglantiAdresi")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<int>("CalisanID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("HesapTuru")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("BaglantiSosyalMedyaID");

                    b.HasIndex("CalisanID")
                        .IsUnique();

                    b.ToTable("BaglantiSosyalMedyalar");
                });

            modelBuilder.Entity("Entities.Concrete.Banka", b =>
                {
                    b.Property<int>("BankaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BankaAdi")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<int>("CalisanId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("HesapNo")
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<int>("HesapTipi")
                        .HasColumnType("int");

                    b.Property<string>("IBAN")
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("BankaId");

                    b.HasIndex("CalisanId")
                        .IsUnique();

                    b.ToTable("Bankalar");
                });

            modelBuilder.Entity("Entities.Concrete.Calisan", b =>
                {
                    b.Property<int>("CalisanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AcilDurumBilgiID")
                        .HasColumnType("int");

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<int?>("AdresId")
                        .HasColumnType("int");

                    b.Property<bool>("AktifMi")
                        .HasColumnType("bit");

                    b.Property<int?>("BaglantiSosyalMedyaId")
                        .HasColumnType("int");

                    b.Property<int?>("BankaId")
                        .HasColumnType("int");

                    b.Property<int>("CalisanAvansID")
                        .HasColumnType("int");

                    b.Property<int?>("Cinsiyet")
                        .HasColumnType("int");

                    b.Property<int>("CocukSayisi")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EgitimDurumu")
                        .HasColumnType("int");

                    b.Property<int?>("EgitimSeviyesi")
                        .HasColumnType("int");

                    b.Property<int?>("EngelDerecesi")
                        .HasColumnType("int");

                    b.Property<int>("ErisimTuru")
                        .HasColumnType("int");

                    b.Property<string>("Fotograf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("IseGirisTarihi")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int?>("KalanIzinSayisi")
                        .HasColumnType("int");

                    b.Property<int?>("KanGrubu")
                        .HasColumnType("int");

                    b.Property<int?>("KullandigiIzinSayisi")
                        .HasColumnType("int");

                    b.Property<int?>("KullaniciYorumuId")
                        .HasColumnType("int");

                    b.Property<string>("MailIs")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("MailKisisel")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<int?>("MedeniDurum")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SirketId")
                        .HasColumnType("int");

                    b.Property<string>("SonTamamlananEgitimKurumu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<DateTime?>("SozlesmeBitisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("SozlesmeTuru")
                        .HasColumnType("int");

                    b.Property<string>("TcNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelIs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelKisisel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Uyruk")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CalisanId");

                    b.HasIndex("SirketId");

                    b.ToTable("Calisanlar");
                });

            modelBuilder.Entity("Entities.Concrete.CalisanAvans", b =>
                {
                    b.Property<int>("CalisanAvansID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Acıklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AvansMiktarı")
                        .HasColumnType("int");

                    b.Property<DateTime>("AvansTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("CalisanID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TaksitSayısı")
                        .HasColumnType("int");

                    b.HasKey("CalisanAvansID");

                    b.HasIndex("CalisanID");

                    b.ToTable("CalisanAvanslar");
                });

            modelBuilder.Entity("Entities.Concrete.CalisanHarcama", b =>
                {
                    b.Property<int>("CalisanHarcamaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CalisanId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("HarcamaAciklamasi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HarcamaBelgesiYolu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("HarcamaMiktari")
                        .HasColumnType("float");

                    b.Property<DateTime>("HarcamaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CalisanHarcamaID");

                    b.HasIndex("CalisanId");

                    b.ToTable("CalisanHarcamalari");
                });

            modelBuilder.Entity("Entities.Concrete.CalisanKariyer", b =>
                {
                    b.Property<int>("CalisanKariyerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CalisanId")
                        .HasColumnType("int");

                    b.Property<string>("CalismaSekli")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Departman")
                        .HasColumnType("int");

                    b.Property<DateTime>("IseGirisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("IstenCikisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("Maas")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Sirket")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Sube")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<int>("Unvan")
                        .HasColumnType("int");

                    b.HasKey("CalisanKariyerId");

                    b.HasIndex("CalisanId");

                    b.ToTable("CalisanKariyerler");
                });

            modelBuilder.Entity("Entities.Concrete.EgitimBilgi", b =>
                {
                    b.Property<int>("EgitimBilgiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CalisanEgitimViewModelCalisanId")
                        .HasColumnType("int");

                    b.Property<int>("CalisanId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EgitimSeviyesi")
                        .HasColumnType("int");

                    b.Property<DateTime>("MezuniyetTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OkulAdi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EgitimBilgiId");

                    b.HasIndex("CalisanEgitimViewModelCalisanId");

                    b.HasIndex("CalisanId");

                    b.ToTable("EgitimBilgileri");
                });

            modelBuilder.Entity("Entities.Concrete.Izin", b =>
                {
                    b.Property<int>("IzinID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BaslangicTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("CalisanId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("IzinBelgesiYolu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IzinDetayTalebi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IzinKullanilanGunSayisi")
                        .HasColumnType("int");

                    b.Property<int>("IzinTanimi")
                        .HasColumnType("int");

                    b.Property<DateTime>("MesaiBaslangicTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("OnayRedDurumu")
                        .HasColumnType("bit");

                    b.HasKey("IzinID");

                    b.HasIndex("CalisanId");

                    b.ToTable("Izinler");
                });

            modelBuilder.Entity("Entities.Concrete.KullaniciYorumu", b =>
                {
                    b.Property<int>("KullaniciYorumuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CalisanId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("YorumDetay")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KullaniciYorumuId");

                    b.HasIndex("CalisanId")
                        .IsUnique();

                    b.ToTable("KullaniciYorumlari");
                });

            modelBuilder.Entity("Entities.Concrete.ResmiTatil", b =>
                {
                    b.Property<int>("ResmiTatilId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BaslangicTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BitisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ResmiTatilId");

                    b.ToTable("ResmiTatiller");
                });

            modelBuilder.Entity("Entities.Concrete.Sifre", b =>
                {
                    b.Property<int>("SifreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CalisanId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OlusturulmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Parola")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SifreId");

                    b.HasIndex("CalisanId");

                    b.ToTable("Sifreler");
                });

            modelBuilder.Entity("Entities.Concrete.Sirket", b =>
                {
                    b.Property<int>("SirketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SirketUyelikPlaniId")
                        .HasColumnType("int");

                    b.HasKey("SirketId");

                    b.ToTable("Sirketler");
                });

            modelBuilder.Entity("Entities.Concrete.SirketUyelikPlani", b =>
                {
                    b.Property<int>("SirketUyelikPlaniID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BaslangicTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BitisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SirketID")
                        .HasColumnType("int");

                    b.Property<int>("UyelikPlaniID")
                        .HasColumnType("int");

                    b.HasKey("SirketUyelikPlaniID");

                    b.HasIndex("SirketID")
                        .IsUnique();

                    b.HasIndex("UyelikPlaniID");

                    b.ToTable("SirketUyelikPlanlari");
                });

            modelBuilder.Entity("Entities.Concrete.UyelikPlani", b =>
                {
                    b.Property<int>("UyelikPlaniID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CalisanSayisi")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("PlanUcreti")
                        .HasColumnType("float");

                    b.Property<string>("UyelikPlaniTanimi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UyelikPlaniID");

                    b.ToTable("UyelikPlanilari");
                });

            modelBuilder.Entity("DataAccess.ViewModels.CalisanEgitimViewModel", b =>
                {
                    b.HasOne("Entities.Concrete.Calisan", "Calisan")
                        .WithMany()
                        .HasForeignKey("CalisanId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Concrete.AcilDurumBilgi", b =>
                {
                    b.HasOne("Entities.Concrete.Calisan", "Calisan")
                        .WithOne("AcilDurumBilgi")
                        .HasForeignKey("Entities.Concrete.AcilDurumBilgi", "CalisanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Concrete.Adres", b =>
                {
                    b.HasOne("Entities.Concrete.Calisan", "Calisan")
                        .WithOne("Adres")
                        .HasForeignKey("Entities.Concrete.Adres", "CalisanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Concrete.BaglantiSosyalMedya", b =>
                {
                    b.HasOne("Entities.Concrete.Calisan", "Calisan")
                        .WithOne("BaglantiSosyalMedya")
                        .HasForeignKey("Entities.Concrete.BaglantiSosyalMedya", "CalisanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Concrete.Banka", b =>
                {
                    b.HasOne("Entities.Concrete.Calisan", "Calisan")
                        .WithOne("Banka")
                        .HasForeignKey("Entities.Concrete.Banka", "CalisanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Concrete.Calisan", b =>
                {
                    b.HasOne("Entities.Concrete.Sirket", "Sirket")
                        .WithMany("Calisanlar")
                        .HasForeignKey("SirketId")
                        .OnDelete(DeleteBehavior.NoAction);
                });

            modelBuilder.Entity("Entities.Concrete.CalisanAvans", b =>
                {
                    b.HasOne("Entities.Concrete.Calisan", "Calisan")
                        .WithMany("CalisanAvans")
                        .HasForeignKey("CalisanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Concrete.CalisanHarcama", b =>
                {
                    b.HasOne("Entities.Concrete.Calisan", "Calisan")
                        .WithMany("CalisanHarcama")
                        .HasForeignKey("CalisanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Concrete.CalisanKariyer", b =>
                {
                    b.HasOne("Entities.Concrete.Calisan", "Calisan")
                        .WithMany("CalisanKariyer")
                        .HasForeignKey("CalisanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Concrete.EgitimBilgi", b =>
                {
                    b.HasOne("DataAccess.ViewModels.CalisanEgitimViewModel", null)
                        .WithMany("EgitimBilgileri")
                        .HasForeignKey("CalisanEgitimViewModelCalisanId");

                    b.HasOne("Entities.Concrete.Calisan", "Calisan")
                        .WithMany("EgitimBilgileri")
                        .HasForeignKey("CalisanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Concrete.Izin", b =>
                {
                    b.HasOne("Entities.Concrete.Calisan", "Calisan")
                        .WithMany("Izinler")
                        .HasForeignKey("CalisanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Concrete.KullaniciYorumu", b =>
                {
                    b.HasOne("Entities.Concrete.Calisan", "Calisan")
                        .WithOne("KullaniciYorumu")
                        .HasForeignKey("Entities.Concrete.KullaniciYorumu", "CalisanId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Concrete.Sifre", b =>
                {
                    b.HasOne("Entities.Concrete.Calisan", "Calisan")
                        .WithMany("Sifreler")
                        .HasForeignKey("CalisanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Concrete.SirketUyelikPlani", b =>
                {
                    b.HasOne("Entities.Concrete.Sirket", "Sirket")
                        .WithOne("SirketUyelikPlani")
                        .HasForeignKey("Entities.Concrete.SirketUyelikPlani", "SirketID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.UyelikPlani", "UyelikPlani")
                        .WithMany("SirketUyelikPlani")
                        .HasForeignKey("UyelikPlaniID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}