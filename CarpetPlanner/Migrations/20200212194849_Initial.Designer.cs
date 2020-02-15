﻿// <auto-generated />
using System;
using CarpetPlanner.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarpetPlanner.Migrations
{
    [DbContext(typeof(CarpetDataContext))]
    [Migration("20200212194849_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CarpetPlanner.Models.CarpetEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<bool>("Removed");

                    b.Property<int>("StripeSeparator");

                    b.Property<string>("Username");

                    b.Property<int>("Width")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(100);

                    b.HasKey("Id");

                    b.ToTable("Carpets");
                });

            modelBuilder.Entity("CarpetPlanner.Models.ColorEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Ordinal");

                    b.Property<bool>("Removed");

                    b.Property<string>("Rgb");

                    b.HasKey("Id");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("CarpetPlanner.Models.StripeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CarpetEntityId");

                    b.Property<int>("CarpetId");

                    b.Property<int>("Color");

                    b.Property<double>("Height");

                    b.HasKey("Id");

                    b.HasIndex("CarpetEntityId");

                    b.ToTable("Stripes");
                });

            modelBuilder.Entity("CarpetPlanner.Models.StripeEntity", b =>
                {
                    b.HasOne("CarpetPlanner.Models.CarpetEntity")
                        .WithMany("Stripes")
                        .HasForeignKey("CarpetEntityId");
                });
#pragma warning restore 612, 618
        }
    }
}
