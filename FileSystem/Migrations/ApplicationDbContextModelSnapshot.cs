﻿// <auto-generated />
using System;
using FileSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FileSystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FileSystem.Models.FileModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Extension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UploadedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FileModels");

                    b.HasDiscriminator<string>("Discriminator").HasValue("FileModel");
                });

            modelBuilder.Entity("FileSystem.Models.FileDatabaseModel", b =>
                {
                    b.HasBaseType("FileSystem.Models.FileModel");

                    b.Property<byte[]>("Data")
                        .HasColumnType("varbinary(max)");

                    b.HasDiscriminator().HasValue("FileDatabaseModel");
                });

            modelBuilder.Entity("FileSystem.Models.FileSystemModel", b =>
                {
                    b.HasBaseType("FileSystem.Models.FileModel");

                    b.Property<string>("FilePath")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("FileSystemModel");
                });
#pragma warning restore 612, 618
        }
    }
}