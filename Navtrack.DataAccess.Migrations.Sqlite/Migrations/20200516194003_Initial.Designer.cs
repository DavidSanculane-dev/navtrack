﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Navtrack.DataAccess.Model;

namespace Navtrack.DataAccess.Migrations.Sqlite.Migrations
{
    [DbContext(typeof(NavtrackDbContext))]
    [Migration("20200516194003_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("Navtrack.DataAccess.Model.Asset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("DeviceId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DeviceId")
                        .IsUnique();

                    b.ToTable("Assets");
                });

            modelBuilder.Entity("Navtrack.DataAccess.Model.Configuration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(500);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Configurations");
                });

            modelBuilder.Entity("Navtrack.DataAccess.Model.Connection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ClosedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("OpenedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("RemoteEndPoint")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(64);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Connections");
                });

            modelBuilder.Entity("Navtrack.DataAccess.Model.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("DeviceTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("IMEI")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(15);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("Navtrack.DataAccess.Model.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("Altitude")
                        .HasColumnType("decimal(7, 2)");

                    b.Property<int>("AssetId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CellId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("DeviceId")
                        .HasColumnType("INTEGER");

                    b.Property<short?>("GsmSignal")
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("HDOP")
                        .HasColumnType("decimal(4, 2)");

                    b.Property<decimal?>("Heading")
                        .HasColumnType("decimal(5, 2)");

                    b.Property<decimal>("Latitude")
                        .HasColumnType("decimal(9, 6)");

                    b.Property<int?>("LocationAreaCode")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Longitude")
                        .HasColumnType("decimal(9, 6)");

                    b.Property<int?>("MobileCountryCode")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MobileNetworkCode")
                        .HasColumnType("INTEGER");

                    b.Property<double?>("Odometer")
                        .HasColumnType("REAL");

                    b.Property<bool?>("PositionStatus")
                        .HasColumnType("INTEGER");

                    b.Property<short?>("Satellites")
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("Speed")
                        .HasColumnType("decimal(6, 2)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.HasIndex("DeviceId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("Navtrack.DataAccess.Model.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Data")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("Navtrack.DataAccess.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(254);

                    b.Property<string>("Hash")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(88);

                    b.Property<int>("Role")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(44);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Navtrack.DataAccess.Model.UserAsset", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AssetId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "AssetId");

                    b.HasIndex("AssetId");

                    b.ToTable("UserAsset");
                });

            modelBuilder.Entity("Navtrack.DataAccess.Model.UserDevice", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DeviceId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "DeviceId");

                    b.HasIndex("DeviceId");

                    b.ToTable("UserDevice");
                });

            modelBuilder.Entity("Navtrack.DataAccess.Model.Asset", b =>
                {
                    b.HasOne("Navtrack.DataAccess.Model.Device", "Device")
                        .WithOne("Asset")
                        .HasForeignKey("Navtrack.DataAccess.Model.Asset", "DeviceId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Navtrack.DataAccess.Model.Location", b =>
                {
                    b.HasOne("Navtrack.DataAccess.Model.Asset", "Asset")
                        .WithMany("Locations")
                        .HasForeignKey("AssetId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Navtrack.DataAccess.Model.Device", "Device")
                        .WithMany("Locations")
                        .HasForeignKey("DeviceId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Navtrack.DataAccess.Model.UserAsset", b =>
                {
                    b.HasOne("Navtrack.DataAccess.Model.Asset", "Asset")
                        .WithMany("Users")
                        .HasForeignKey("AssetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Navtrack.DataAccess.Model.User", "User")
                        .WithMany("Assets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Navtrack.DataAccess.Model.UserDevice", b =>
                {
                    b.HasOne("Navtrack.DataAccess.Model.Device", "Device")
                        .WithMany("Users")
                        .HasForeignKey("DeviceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Navtrack.DataAccess.Model.User", "User")
                        .WithMany("Devices")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
