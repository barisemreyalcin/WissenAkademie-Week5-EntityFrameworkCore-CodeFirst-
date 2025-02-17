﻿// <auto-generated />
using System;
using DataAnnotationAndFluentApi.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAnnotationAndFluentApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataAnnotationAndFluentApi.Model.Author", b =>
                {
                    b.Property<int>("AuthorKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AuthorID")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorKey"));

                    b.Property<string>("Biography")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnOrder(5);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DoB")
                        .HasColumnOrder(4);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnOrder(2);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnOrder(3);

                    b.HasKey("AuthorKey");

                    b.ToTable("AuthorTable");

                    b.HasData(
                        new
                        {
                            AuthorKey = 1,
                            Biography = "Sample bio text.",
                            BirthDate = new DateTime(1520, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "William",
                            LastName = "Shakespeare"
                        },
                        new
                        {
                            AuthorKey = 2,
                            Biography = "Another sample bio text.",
                            BirthDate = new DateTime(1720, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Fyodor",
                            LastName = "Dostoyevski"
                        });
                });

            modelBuilder.Entity("DataAnnotationAndFluentApi.Model.Book", b =>
                {
                    b.Property<int>("BookKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("BookID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookKey"));

                    b.Property<int>("AuthorFK")
                        .HasColumnType("int");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 4)")
                        .HasColumnName("BookPrice");

                    b.Property<int>("PublishCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Book_Title")
                        .HasColumnOrder(2);

                    b.HasKey("BookKey");

                    b.HasIndex("AuthorFK");

                    b.ToTable("Books", (string)null);

                    b.HasData(
                        new
                        {
                            BookKey = 1,
                            AuthorFK = 2,
                            ISBN = "1234-5678-9101-1121",
                            Price = 400m,
                            PublishCount = 20,
                            PublishDate = new DateTime(1874, 7, 14, 13, 23, 51, 287, DateTimeKind.Local).AddTicks(7170),
                            Title = "Suç ve Ceza"
                        },
                        new
                        {
                            BookKey = 2,
                            AuthorFK = 2,
                            ISBN = "1234-5678-9101-1122",
                            Price = 300m,
                            PublishCount = 15,
                            PublishDate = new DateTime(1884, 7, 14, 13, 23, 51, 287, DateTimeKind.Local).AddTicks(7197),
                            Title = "Yer Altından Notlar"
                        },
                        new
                        {
                            BookKey = 3,
                            AuthorFK = 2,
                            ISBN = "1234-5678-9101-1123",
                            Price = 200m,
                            PublishCount = 10,
                            PublishDate = new DateTime(1872, 7, 14, 13, 23, 51, 287, DateTimeKind.Local).AddTicks(7202),
                            Title = "Beyaz Geceler"
                        });
                });

            modelBuilder.Entity("DataAnnotationAndFluentApi.Model.Book", b =>
                {
                    b.HasOne("DataAnnotationAndFluentApi.Model.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("DataAnnotationAndFluentApi.Model.Author", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
