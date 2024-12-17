﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Movies.Models;

#nullable disable

namespace Movies.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20241217041540_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Movies.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Rating")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("Year")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("MovieId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieId = 123,
                            Name = "The God Father",
                            Rating = 5,
                            Year = 2010
                        },
                        new
                        {
                            MovieId = 523,
                            Name = "Kill Bill",
                            Rating = 4,
                            Year = 2008
                        },
                        new
                        {
                            MovieId = 1233,
                            Name = "Interstellar",
                            Rating = 5,
                            Year = 2015
                        },
                        new
                        {
                            MovieId = 223,
                            Name = "Scream",
                            Rating = 2,
                            Year = 1972
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
