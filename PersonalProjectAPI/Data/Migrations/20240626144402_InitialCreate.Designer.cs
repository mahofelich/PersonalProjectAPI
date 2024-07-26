﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PersonalProjectAPI.Data;

#nullable disable

namespace PersonalProjectAPI.Data.Migrations
{
    [DbContext(typeof(StandListContext))]
    [Migration("20240626144402_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("PersonalProjectAPI.Entities.Stand", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<char>("Persistence")
                        .HasColumnType("TEXT");

                    b.Property<char>("Potential")
                        .HasColumnType("TEXT");

                    b.Property<char>("Power")
                        .HasColumnType("TEXT");

                    b.Property<char>("Precision")
                        .HasColumnType("TEXT");

                    b.Property<char>("Range")
                        .HasColumnType("TEXT");

                    b.Property<char>("Speed")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Stands");
                });
#pragma warning restore 612, 618
        }
    }
}
