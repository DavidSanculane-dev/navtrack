﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Navtrack.DataAccess.Model;

namespace Navtrack.DataAccess.Migrations
{
    [DbContext(typeof(NavtrackContext))]
    [Migration("20191123003007_AddDeviceTypeData")]
    partial class AddDeviceTypeData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Navtrack.DataAccess.Model.Asset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DeviceId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("DeviceId")
                        .IsUnique();

                    b.ToTable("Assets");
                });

            modelBuilder.Entity("Navtrack.DataAccess.Model.Connection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("ClosedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OpenedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("RemoteEndPoint")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("Connections");
                });

            modelBuilder.Entity("Navtrack.DataAccess.Model.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DeviceTypeId")
                        .HasColumnType("int");

                    b.Property<string>("IMEI")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("DeviceTypeId");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("Navtrack.DataAccess.Model.DeviceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("ProtocolId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DeviceTypes");
                });

            modelBuilder.Entity("Navtrack.DataAccess.Model.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Altitude")
                        .HasColumnType("int");

                    b.Property<int>("AssetId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("DeviceId")
                        .HasColumnType("int");

                    b.Property<double>("HDOP")
                        .HasColumnType("float");

                    b.Property<int>("Heading")
                        .HasColumnType("int");

                    b.Property<decimal>("Latitude")
                        .HasColumnType("decimal(9, 6)");

                    b.Property<decimal>("Longitude")
                        .HasColumnType("decimal(9, 6)");

                    b.Property<string>("ProtocolData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("Satellites")
                        .HasColumnType("smallint");

                    b.Property<int>("Speed")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.HasIndex("DeviceId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("Navtrack.DataAccess.Model.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("Navtrack.DataAccess.Model.Asset", b =>
                {
                    b.HasOne("Navtrack.DataAccess.Model.Device", "Device")
                        .WithOne("Asset")
                        .HasForeignKey("Navtrack.DataAccess.Model.Asset", "DeviceId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Navtrack.DataAccess.Model.Device", b =>
                {
                    b.HasOne("Navtrack.DataAccess.Model.DeviceType", "DeviceType")
                        .WithMany("Devices")
                        .HasForeignKey("DeviceTypeId")
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
#pragma warning restore 612, 618
        }
    }
}
