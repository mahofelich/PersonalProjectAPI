﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PersonalProjectAPI.Data;

#nullable disable

namespace PersonalProjectAPI.Data.Migrations
{
    [DbContext(typeof(StandListContext))]
    partial class StandListContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("PersonalProjectAPI.Entities.Stand", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("Img")
                        .HasColumnType("BLOB");

                    b.Property<string>("Name")
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
