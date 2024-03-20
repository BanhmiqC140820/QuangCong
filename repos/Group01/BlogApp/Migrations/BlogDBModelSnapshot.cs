﻿// <auto-generated />
using System;
using BlogApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlogApp.Migrations
{
    [DbContext(typeof(BlogDB))]
    partial class BlogDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.14");

            modelBuilder.Entity("BlogApp.Models.Article", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateUpdate")
                        .HasColumnType("TEXT");

                    b.Property<long>("IdCategory")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("IdCategory");

                    b.ToTable("Article");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Author = "John Doe",
                            Content = "Entity Framework Core is an ORM framework...",
                            DateCreated = new DateTime(2023, 11, 25, 15, 8, 0, 176, DateTimeKind.Local).AddTicks(3180),
                            IdCategory = 1L,
                            Title = "Introduction to EF Core"
                        },
                        new
                        {
                            Id = 2L,
                            Author = "Jane Smith",
                            Content = "Artificial Intelligence is reshaping industries...",
                            DateCreated = new DateTime(2023, 11, 25, 15, 8, 0, 176, DateTimeKind.Local).AddTicks(3183),
                            IdCategory = 2L,
                            Title = "Advancements in AI"
                        },
                        new
                        {
                            Id = 3L,
                            Author = "Jane Smith",
                            Content = "Artificial Intelligence is reshaping industries...",
                            DateCreated = new DateTime(2023, 11, 25, 15, 8, 0, 176, DateTimeKind.Local).AddTicks(3184),
                            IdCategory = 2L,
                            Title = "Advancements in AI"
                        },
                        new
                        {
                            Id = 4L,
                            Author = "Jane Smith",
                            Content = "Artificial Intelligence is reshaping industries...",
                            DateCreated = new DateTime(2023, 11, 25, 15, 8, 0, 176, DateTimeKind.Local).AddTicks(3185),
                            IdCategory = 4L,
                            Title = "Advancements"
                        },
                        new
                        {
                            Id = 5L,
                            Author = "Jane Smith",
                            Content = "Artificial Intelligence is reshaping industries...",
                            DateCreated = new DateTime(2023, 11, 25, 15, 8, 0, 176, DateTimeKind.Local).AddTicks(3186),
                            IdCategory = 5L,
                            Title = "Advancements"
                        });
                });

            modelBuilder.Entity("BlogApp.Models.Category", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateUpdate")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            id = 1L,
                            DateCreated = new DateTime(2023, 11, 25, 15, 8, 0, 176, DateTimeKind.Local).AddTicks(3025),
                            name = "Technology"
                        },
                        new
                        {
                            id = 2L,
                            DateCreated = new DateTime(2023, 11, 25, 15, 8, 0, 176, DateTimeKind.Local).AddTicks(3034),
                            name = "Science"
                        },
                        new
                        {
                            id = 3L,
                            DateCreated = new DateTime(2023, 11, 25, 15, 8, 0, 176, DateTimeKind.Local).AddTicks(3035),
                            name = "Media"
                        },
                        new
                        {
                            id = 4L,
                            DateCreated = new DateTime(2023, 11, 25, 15, 8, 0, 176, DateTimeKind.Local).AddTicks(3036),
                            name = "Secret"
                        },
                        new
                        {
                            id = 5L,
                            DateCreated = new DateTime(2023, 11, 25, 15, 8, 0, 176, DateTimeKind.Local).AddTicks(3037),
                            name = "Sound effect"
                        });
                });

            modelBuilder.Entity("BlogApp.Models.Article", b =>
                {
                    b.HasOne("BlogApp.Models.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("IdCategory")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BlogApp.Models.Category", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}
