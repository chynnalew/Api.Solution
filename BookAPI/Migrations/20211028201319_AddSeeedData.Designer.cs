﻿// <auto-generated />
using BookAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookAPI.Migrations
{
    [DbContext(typeof(BookAPIContext))]
    [Migration("20211028201319_AddSeeedData")]
    partial class AddSeeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("BookAPI.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Author")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Genre")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<bool>("Read")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Title")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("BookId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            Author = "J. K. Rowling",
                            Genre = "Fantasy",
                            Rating = 8,
                            Read = true,
                            Title = "Harry Potter"
                        },
                        new
                        {
                            BookId = 2,
                            Author = "Alex Michaelides",
                            Genre = "Thriller",
                            Rating = 5,
                            Read = false,
                            Title = "The Silent Patient"
                        },
                        new
                        {
                            BookId = 3,
                            Author = "Philip K. Dick",
                            Genre = "Sci-Fi",
                            Rating = 8,
                            Read = true,
                            Title = "Do Androids Dream of Electric Sheep"
                        },
                        new
                        {
                            BookId = 4,
                            Author = "Rachel Carson",
                            Genre = "Non-Fiction",
                            Rating = 8,
                            Read = true,
                            Title = "Silent Spring"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
