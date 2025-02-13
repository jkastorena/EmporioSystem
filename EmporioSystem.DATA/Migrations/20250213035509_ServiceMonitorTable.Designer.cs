﻿// <auto-generated />
using System;
using EmporioSystem.DATA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EmporioSystem.DATA.Migrations
{
    [DbContext(typeof(EmporioDataContext))]
    [Migration("20250213035509_ServiceMonitorTable")]
    partial class ServiceMonitorTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EmporioSystem.DATA.ConfigValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Config")
                        .HasColumnType("text");

                    b.Property<int>("ItemConfigId")
                        .HasColumnType("integer");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ItemConfigId");

                    b.ToTable("ConfigValues");
                });

            modelBuilder.Entity("EmporioSystem.DATA.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .HasColumnType("text");

                    b.Property<string>("Category")
                        .HasColumnType("text");

                    b.Property<string>("Color")
                        .HasColumnType("text");

                    b.Property<DateTime?>("DateOfRecive")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateOfShipping")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("Material")
                        .HasColumnType("text");

                    b.Property<string>("Model")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("SerialNumber")
                        .HasColumnType("text");

                    b.Property<string>("Size")
                        .HasColumnType("text");

                    b.Property<string>("SubCategory")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("EmporioSystem.DATA.ItemConfig", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ItemId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("ItemConfigs");
                });

            modelBuilder.Entity("EmporioSystem.DATA.ServiceMonitor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ComputerName")
                        .HasColumnType("text");

                    b.Property<bool>("IsRunning")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("LastRun")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ServiceDescription")
                        .HasColumnType("text");

                    b.Property<string>("ServiceName")
                        .HasColumnType("text");

                    b.Property<string>("ServiceStatus")
                        .HasColumnType("text");

                    b.Property<string>("ServiceType")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ServiceMonitors");
                });

            modelBuilder.Entity("EmporioSystem.DATA.ConfigValue", b =>
                {
                    b.HasOne("EmporioSystem.DATA.ItemConfig", null)
                        .WithMany("ConfigValues")
                        .HasForeignKey("ItemConfigId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EmporioSystem.DATA.ItemConfig", b =>
                {
                    b.Navigation("ConfigValues");
                });
#pragma warning restore 612, 618
        }
    }
}
