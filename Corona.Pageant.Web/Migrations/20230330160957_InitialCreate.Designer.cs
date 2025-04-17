﻿// <auto-generated />
using Corona.Pageant.Web.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Corona.Pageant.Migrations
{
    [DbContext(typeof(PageantDb))]
    [Migration("20230330160957_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("Corona.Pageant.Models.Scripts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Act")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Camera1Action")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Camera1Position")
                        .HasColumnType("TEXT");

                    b.Property<string>("Camera2Action")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Camera2Position")
                        .HasColumnType("TEXT");

                    b.Property<string>("Camera3Action")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Camera3Position")
                        .HasColumnType("TEXT");

                    b.Property<string>("Scene")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SwitchToScene")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Scripts");
                });

            modelBuilder.Entity("Corona.Pageant.Models.Settings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Setting")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SettingId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SettingType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Settings");
                });
#pragma warning restore 612, 618
        }
    }
}
