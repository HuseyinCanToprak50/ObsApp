﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ObsApp;

#nullable disable

namespace ObsApp.Migrations
{
    [DbContext(typeof(OkulDbContext))]
    [Migration("20241227163531_InitDbObs")]
    partial class InitDbObs
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ObsApp.Ogrenciler", b =>
                {
                    b.Property<int>("OgrenciId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OgrenciId"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numara")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SinifId")
                        .HasColumnType("int");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OgrenciId");

                    b.HasIndex("SinifId");

                    b.ToTable("Ogrenciler");
                });

            modelBuilder.Entity("ObsApp.tblDersler", b =>
                {
                    b.Property<int>("DersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DersId"));

                    b.Property<string>("DersAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DersKodu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DersId");

                    b.ToTable("Dersler");
                });

            modelBuilder.Entity("ObsApp.tblOgrenciDers", b =>
                {
                    b.Property<int>("DersId")
                        .HasColumnType("int");

                    b.Property<int>("OgrenciId")
                        .HasColumnType("int");

                    b.Property<Guid>("TempKey")
                        .HasColumnType("uniqueidentifier");

                    b.ToTable("OgrenciDersler");
                });

            modelBuilder.Entity("ObsApp.tblSiniflar", b =>
                {
                    b.Property<int>("SinifId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SinifId"));

                    b.Property<string>("Kontenjan")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar");

                    b.Property<string>("SinifAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SinifId");

                    b.ToTable("Siniflar");
                });

            modelBuilder.Entity("ObsApp.Ogrenciler", b =>
                {
                    b.HasOne("ObsApp.tblSiniflar", "Sinif")
                        .WithMany("Ogrenciler")
                        .HasForeignKey("SinifId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sinif");
                });

            modelBuilder.Entity("ObsApp.tblSiniflar", b =>
                {
                    b.Navigation("Ogrenciler");
                });
#pragma warning restore 612, 618
        }
    }
}
