﻿// <auto-generated />
using System;
using MegaDeskv3._0.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MegaDeskv3._0.Migrations
{
    [DbContext(typeof(MegaDeskv3_0Context))]
    [Migration("20220608004915_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MegaDeskv3._0.Models.DeskQuote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("customerFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customerLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("depth")
                        .HasColumnType("int");

                    b.Property<int>("drawers")
                        .HasColumnType("int");

                    b.Property<DateTime>("quoteDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("quoteTotal")
                        .HasColumnType("int");

                    b.Property<int>("rushDays")
                        .HasColumnType("int");

                    b.Property<string>("surfaceMaterial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DeskQuote");
                });
#pragma warning restore 612, 618
        }
    }
}
