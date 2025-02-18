﻿// <auto-generated />
using System;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(CricketerDbContext))]
    [Migration("20240911075117_dbscript")]
    partial class dbscript
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("DataAccessLayer.Entity.CricketerDetails", b =>
                {
                    b.Property<long>("CricketersID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("CricketerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<long>("HighestScore")
                        .HasColumnType("bigint");

                    b.Property<long>("NumberOfFifties")
                        .HasColumnType("bigint");

                    b.Property<long>("NumberOfHundreds")
                        .HasColumnType("bigint");

                    b.Property<long>("TotalScore")
                        .HasColumnType("bigint");

                    b.Property<long>("Totalinnings")
                        .HasColumnType("bigint");

                    b.HasKey("CricketersID");

                    b.ToTable("CricketerDetail");
                });
#pragma warning restore 612, 618
        }
    }
}
