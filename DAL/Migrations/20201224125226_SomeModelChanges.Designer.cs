﻿// <auto-generated />
using System;
using DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(SAPContext))]
    [Migration("20201224125226_SomeModelChanges")]
    partial class SomeModelChanges
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("DAL.Entities.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Number = "IS-11"
                        },
                        new
                        {
                            Id = 2,
                            Number = "IS-12"
                        },
                        new
                        {
                            Id = 3,
                            Number = "IS-13"
                        },
                        new
                        {
                            Id = 4,
                            Number = "IS-21"
                        },
                        new
                        {
                            Id = 5,
                            Number = "IS-22"
                        },
                        new
                        {
                            Id = 6,
                            Number = "IS-23"
                        });
                });

            modelBuilder.Entity("DAL.Entities.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal>("Score")
                        .HasColumnType("decimal(5,2)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Ratings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Score = 8.23m,
                            StudentId = 1,
                            SubjectId = 1
                        },
                        new
                        {
                            Id = 2,
                            Score = 3.09m,
                            StudentId = 2,
                            SubjectId = 1
                        },
                        new
                        {
                            Id = 3,
                            Score = 4.16m,
                            StudentId = 3,
                            SubjectId = 1
                        },
                        new
                        {
                            Id = 4,
                            Score = 0.17m,
                            StudentId = 4,
                            SubjectId = 1
                        },
                        new
                        {
                            Id = 5,
                            Score = 5.60m,
                            StudentId = 5,
                            SubjectId = 1
                        },
                        new
                        {
                            Id = 6,
                            Score = 0.75m,
                            StudentId = 1,
                            SubjectId = 2
                        },
                        new
                        {
                            Id = 7,
                            Score = 9.50m,
                            StudentId = 2,
                            SubjectId = 2
                        },
                        new
                        {
                            Id = 8,
                            Score = 6.88m,
                            StudentId = 3,
                            SubjectId = 2
                        },
                        new
                        {
                            Id = 9,
                            Score = 7.61m,
                            StudentId = 4,
                            SubjectId = 2
                        },
                        new
                        {
                            Id = 10,
                            Score = 9.78m,
                            StudentId = 5,
                            SubjectId = 2
                        },
                        new
                        {
                            Id = 11,
                            Score = 9.63m,
                            StudentId = 1,
                            SubjectId = 3
                        },
                        new
                        {
                            Id = 12,
                            Score = 9.01m,
                            StudentId = 2,
                            SubjectId = 3
                        },
                        new
                        {
                            Id = 13,
                            Score = 1.13m,
                            StudentId = 3,
                            SubjectId = 3
                        },
                        new
                        {
                            Id = 14,
                            Score = 0.82m,
                            StudentId = 4,
                            SubjectId = 3
                        },
                        new
                        {
                            Id = 15,
                            Score = 9.83m,
                            StudentId = 5,
                            SubjectId = 3
                        },
                        new
                        {
                            Id = 16,
                            Score = 2.24m,
                            StudentId = 6,
                            SubjectId = 1
                        },
                        new
                        {
                            Id = 17,
                            Score = 0.90m,
                            StudentId = 7,
                            SubjectId = 1
                        },
                        new
                        {
                            Id = 18,
                            Score = 1.23m,
                            StudentId = 8,
                            SubjectId = 1
                        },
                        new
                        {
                            Id = 19,
                            Score = 6.37m,
                            StudentId = 9,
                            SubjectId = 1
                        },
                        new
                        {
                            Id = 20,
                            Score = 8.32m,
                            StudentId = 10,
                            SubjectId = 1
                        },
                        new
                        {
                            Id = 21,
                            Score = 1.24m,
                            StudentId = 6,
                            SubjectId = 2
                        },
                        new
                        {
                            Id = 22,
                            Score = 3.70m,
                            StudentId = 7,
                            SubjectId = 2
                        },
                        new
                        {
                            Id = 23,
                            Score = 0.05m,
                            StudentId = 8,
                            SubjectId = 2
                        },
                        new
                        {
                            Id = 24,
                            Score = 5.86m,
                            StudentId = 9,
                            SubjectId = 2
                        },
                        new
                        {
                            Id = 25,
                            Score = 8.70m,
                            StudentId = 10,
                            SubjectId = 2
                        },
                        new
                        {
                            Id = 26,
                            Score = 5.38m,
                            StudentId = 6,
                            SubjectId = 3
                        },
                        new
                        {
                            Id = 27,
                            Score = 6.88m,
                            StudentId = 7,
                            SubjectId = 3
                        },
                        new
                        {
                            Id = 28,
                            Score = 2.54m,
                            StudentId = 8,
                            SubjectId = 3
                        },
                        new
                        {
                            Id = 29,
                            Score = 4.89m,
                            StudentId = 9,
                            SubjectId = 3
                        },
                        new
                        {
                            Id = 30,
                            Score = 4.68m,
                            StudentId = 10,
                            SubjectId = 3
                        },
                        new
                        {
                            Id = 31,
                            Score = 2.30m,
                            StudentId = 11,
                            SubjectId = 1
                        },
                        new
                        {
                            Id = 32,
                            Score = 5.77m,
                            StudentId = 12,
                            SubjectId = 1
                        },
                        new
                        {
                            Id = 33,
                            Score = 8.58m,
                            StudentId = 13,
                            SubjectId = 1
                        },
                        new
                        {
                            Id = 34,
                            Score = 1.52m,
                            StudentId = 14,
                            SubjectId = 1
                        },
                        new
                        {
                            Id = 35,
                            Score = 2.40m,
                            StudentId = 15,
                            SubjectId = 1
                        },
                        new
                        {
                            Id = 36,
                            Score = 3.80m,
                            StudentId = 11,
                            SubjectId = 2
                        },
                        new
                        {
                            Id = 37,
                            Score = 9.28m,
                            StudentId = 12,
                            SubjectId = 2
                        },
                        new
                        {
                            Id = 38,
                            Score = 8.38m,
                            StudentId = 13,
                            SubjectId = 2
                        },
                        new
                        {
                            Id = 39,
                            Score = 4.49m,
                            StudentId = 14,
                            SubjectId = 2
                        },
                        new
                        {
                            Id = 40,
                            Score = 8.31m,
                            StudentId = 15,
                            SubjectId = 2
                        },
                        new
                        {
                            Id = 41,
                            Score = 4.89m,
                            StudentId = 11,
                            SubjectId = 3
                        },
                        new
                        {
                            Id = 42,
                            Score = 7.10m,
                            StudentId = 12,
                            SubjectId = 3
                        },
                        new
                        {
                            Id = 43,
                            Score = 6.40m,
                            StudentId = 13,
                            SubjectId = 3
                        },
                        new
                        {
                            Id = 44,
                            Score = 2.02m,
                            StudentId = 14,
                            SubjectId = 3
                        },
                        new
                        {
                            Id = 45,
                            Score = 9.03m,
                            StudentId = 15,
                            SubjectId = 3
                        },
                        new
                        {
                            Id = 46,
                            Score = 3.99m,
                            StudentId = 16,
                            SubjectId = 4
                        },
                        new
                        {
                            Id = 47,
                            Score = 2.26m,
                            StudentId = 17,
                            SubjectId = 4
                        },
                        new
                        {
                            Id = 48,
                            Score = 1.13m,
                            StudentId = 18,
                            SubjectId = 4
                        },
                        new
                        {
                            Id = 49,
                            Score = 4.98m,
                            StudentId = 19,
                            SubjectId = 4
                        },
                        new
                        {
                            Id = 50,
                            Score = 4.95m,
                            StudentId = 20,
                            SubjectId = 4
                        },
                        new
                        {
                            Id = 51,
                            Score = 3.09m,
                            StudentId = 16,
                            SubjectId = 5
                        },
                        new
                        {
                            Id = 52,
                            Score = 1.56m,
                            StudentId = 17,
                            SubjectId = 5
                        },
                        new
                        {
                            Id = 53,
                            Score = 0.42m,
                            StudentId = 18,
                            SubjectId = 5
                        },
                        new
                        {
                            Id = 54,
                            Score = 4.66m,
                            StudentId = 19,
                            SubjectId = 5
                        },
                        new
                        {
                            Id = 55,
                            Score = 2.13m,
                            StudentId = 20,
                            SubjectId = 5
                        },
                        new
                        {
                            Id = 56,
                            Score = 4.47m,
                            StudentId = 16,
                            SubjectId = 6
                        },
                        new
                        {
                            Id = 57,
                            Score = 8.03m,
                            StudentId = 17,
                            SubjectId = 6
                        },
                        new
                        {
                            Id = 58,
                            Score = 6.37m,
                            StudentId = 18,
                            SubjectId = 6
                        },
                        new
                        {
                            Id = 59,
                            Score = 3.95m,
                            StudentId = 19,
                            SubjectId = 6
                        },
                        new
                        {
                            Id = 60,
                            Score = 5.79m,
                            StudentId = 20,
                            SubjectId = 6
                        },
                        new
                        {
                            Id = 61,
                            Score = 3.03m,
                            StudentId = 21,
                            SubjectId = 4
                        },
                        new
                        {
                            Id = 62,
                            Score = 9.75m,
                            StudentId = 22,
                            SubjectId = 4
                        },
                        new
                        {
                            Id = 63,
                            Score = 6.06m,
                            StudentId = 23,
                            SubjectId = 4
                        },
                        new
                        {
                            Id = 64,
                            Score = 7.68m,
                            StudentId = 24,
                            SubjectId = 4
                        },
                        new
                        {
                            Id = 65,
                            Score = 1.99m,
                            StudentId = 25,
                            SubjectId = 4
                        },
                        new
                        {
                            Id = 66,
                            Score = 3.30m,
                            StudentId = 21,
                            SubjectId = 5
                        },
                        new
                        {
                            Id = 67,
                            Score = 5.74m,
                            StudentId = 22,
                            SubjectId = 5
                        },
                        new
                        {
                            Id = 68,
                            Score = 8.58m,
                            StudentId = 23,
                            SubjectId = 5
                        },
                        new
                        {
                            Id = 69,
                            Score = 7.86m,
                            StudentId = 24,
                            SubjectId = 5
                        },
                        new
                        {
                            Id = 70,
                            Score = 0.71m,
                            StudentId = 25,
                            SubjectId = 5
                        },
                        new
                        {
                            Id = 71,
                            Score = 6.20m,
                            StudentId = 21,
                            SubjectId = 6
                        },
                        new
                        {
                            Id = 72,
                            Score = 8.29m,
                            StudentId = 22,
                            SubjectId = 6
                        },
                        new
                        {
                            Id = 73,
                            Score = 7.08m,
                            StudentId = 23,
                            SubjectId = 6
                        },
                        new
                        {
                            Id = 74,
                            Score = 9.46m,
                            StudentId = 24,
                            SubjectId = 6
                        },
                        new
                        {
                            Id = 75,
                            Score = 7.60m,
                            StudentId = 25,
                            SubjectId = 6
                        },
                        new
                        {
                            Id = 76,
                            Score = 7.97m,
                            StudentId = 26,
                            SubjectId = 4
                        },
                        new
                        {
                            Id = 77,
                            Score = 7.54m,
                            StudentId = 27,
                            SubjectId = 4
                        },
                        new
                        {
                            Id = 78,
                            Score = 3.89m,
                            StudentId = 28,
                            SubjectId = 4
                        },
                        new
                        {
                            Id = 79,
                            Score = 8.74m,
                            StudentId = 29,
                            SubjectId = 4
                        },
                        new
                        {
                            Id = 80,
                            Score = 9.53m,
                            StudentId = 30,
                            SubjectId = 4
                        },
                        new
                        {
                            Id = 81,
                            Score = 9.92m,
                            StudentId = 26,
                            SubjectId = 5
                        },
                        new
                        {
                            Id = 82,
                            Score = 0.23m,
                            StudentId = 27,
                            SubjectId = 5
                        },
                        new
                        {
                            Id = 83,
                            Score = 2.19m,
                            StudentId = 28,
                            SubjectId = 5
                        },
                        new
                        {
                            Id = 84,
                            Score = 8.50m,
                            StudentId = 29,
                            SubjectId = 5
                        },
                        new
                        {
                            Id = 85,
                            Score = 8.63m,
                            StudentId = 30,
                            SubjectId = 5
                        },
                        new
                        {
                            Id = 86,
                            Score = 8.05m,
                            StudentId = 26,
                            SubjectId = 6
                        },
                        new
                        {
                            Id = 87,
                            Score = 5.07m,
                            StudentId = 27,
                            SubjectId = 6
                        },
                        new
                        {
                            Id = 88,
                            Score = 6.73m,
                            StudentId = 28,
                            SubjectId = 6
                        },
                        new
                        {
                            Id = 89,
                            Score = 5.00m,
                            StudentId = 29,
                            SubjectId = 6
                        },
                        new
                        {
                            Id = 90,
                            Score = 7.53m,
                            StudentId = 30,
                            SubjectId = 6
                        });
                });

            modelBuilder.Entity("DAL.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal>("AvgScore")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(5,2)")
                        .HasDefaultValue(0m);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AvgScore = 0m,
                            FirstName = "Kylo",
                            GroupId = 1,
                            LastName = "Rowland"
                        },
                        new
                        {
                            Id = 2,
                            AvgScore = 0m,
                            FirstName = "Mylee",
                            GroupId = 1,
                            LastName = "Millington"
                        },
                        new
                        {
                            Id = 3,
                            AvgScore = 0m,
                            FirstName = "Summer",
                            GroupId = 1,
                            LastName = "Muir"
                        },
                        new
                        {
                            Id = 4,
                            AvgScore = 0m,
                            FirstName = "Shaunie",
                            GroupId = 1,
                            LastName = "Broughton"
                        },
                        new
                        {
                            Id = 5,
                            AvgScore = 0m,
                            FirstName = "Cienna",
                            GroupId = 1,
                            LastName = "Nixon"
                        },
                        new
                        {
                            Id = 6,
                            AvgScore = 0m,
                            FirstName = "Aaliya",
                            GroupId = 2,
                            LastName = "Arias"
                        },
                        new
                        {
                            Id = 7,
                            AvgScore = 0m,
                            FirstName = "Ansh",
                            GroupId = 2,
                            LastName = "Horne"
                        },
                        new
                        {
                            Id = 8,
                            AvgScore = 0m,
                            FirstName = "Tamera ",
                            GroupId = 2,
                            LastName = "Kramer"
                        },
                        new
                        {
                            Id = 9,
                            AvgScore = 0m,
                            FirstName = "Lucca",
                            GroupId = 2,
                            LastName = "Weiss"
                        },
                        new
                        {
                            Id = 10,
                            AvgScore = 0m,
                            FirstName = "June",
                            GroupId = 2,
                            LastName = "Griffiths"
                        },
                        new
                        {
                            Id = 11,
                            AvgScore = 0m,
                            FirstName = "Graeme",
                            GroupId = 3,
                            LastName = "Dudley"
                        },
                        new
                        {
                            Id = 12,
                            AvgScore = 0m,
                            FirstName = "Kya",
                            GroupId = 3,
                            LastName = "Turnbull"
                        },
                        new
                        {
                            Id = 13,
                            AvgScore = 0m,
                            FirstName = "Jermaine",
                            GroupId = 3,
                            LastName = "Daugherty"
                        },
                        new
                        {
                            Id = 14,
                            AvgScore = 0m,
                            FirstName = "Nelson",
                            GroupId = 3,
                            LastName = "Haden"
                        },
                        new
                        {
                            Id = 15,
                            AvgScore = 0m,
                            FirstName = "Jaylan",
                            GroupId = 3,
                            LastName = "Sloan"
                        },
                        new
                        {
                            Id = 16,
                            AvgScore = 0m,
                            FirstName = "Catherine",
                            GroupId = 4,
                            LastName = "Murillo"
                        },
                        new
                        {
                            Id = 17,
                            AvgScore = 0m,
                            FirstName = "Erik",
                            GroupId = 4,
                            LastName = "Cunningham"
                        },
                        new
                        {
                            Id = 18,
                            AvgScore = 0m,
                            FirstName = "Maribel",
                            GroupId = 4,
                            LastName = "Barnes"
                        },
                        new
                        {
                            Id = 19,
                            AvgScore = 0m,
                            FirstName = "Isaac",
                            GroupId = 4,
                            LastName = "Benton"
                        },
                        new
                        {
                            Id = 20,
                            AvgScore = 0m,
                            FirstName = "Elliott",
                            GroupId = 4,
                            LastName = "Copeland"
                        },
                        new
                        {
                            Id = 21,
                            AvgScore = 0m,
                            FirstName = "Elsa",
                            GroupId = 5,
                            LastName = "Holloway"
                        },
                        new
                        {
                            Id = 22,
                            AvgScore = 0m,
                            FirstName = "Odin",
                            GroupId = 5,
                            LastName = "Haley"
                        },
                        new
                        {
                            Id = 23,
                            AvgScore = 0m,
                            FirstName = "Carter",
                            GroupId = 5,
                            LastName = "Page"
                        },
                        new
                        {
                            Id = 24,
                            AvgScore = 0m,
                            FirstName = "Sonia",
                            GroupId = 5,
                            LastName = "Rose"
                        },
                        new
                        {
                            Id = 25,
                            AvgScore = 0m,
                            FirstName = "Johnathan",
                            GroupId = 5,
                            LastName = "Howell"
                        },
                        new
                        {
                            Id = 26,
                            AvgScore = 0m,
                            FirstName = "Nelson",
                            GroupId = 6,
                            LastName = "Stark"
                        },
                        new
                        {
                            Id = 27,
                            AvgScore = 0m,
                            FirstName = "Bianca",
                            GroupId = 6,
                            LastName = "Bradford"
                        },
                        new
                        {
                            Id = 28,
                            AvgScore = 0m,
                            FirstName = "Ariana",
                            GroupId = 6,
                            LastName = "Hernandez"
                        },
                        new
                        {
                            Id = 29,
                            AvgScore = 0m,
                            FirstName = "Darryl",
                            GroupId = 6,
                            LastName = "Nielsen"
                        },
                        new
                        {
                            Id = 30,
                            AvgScore = 0m,
                            FirstName = "Brooke",
                            GroupId = 6,
                            LastName = "Roberts"
                        });
                });

            modelBuilder.Entity("DAL.Entities.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Title = "Information Systems"
                        },
                        new
                        {
                            Id = 2,
                            Title = "Computer Science"
                        },
                        new
                        {
                            Id = 3,
                            Title = "Software Engineering"
                        },
                        new
                        {
                            Id = 4,
                            Title = "Artificial Intelligence"
                        },
                        new
                        {
                            Id = 5,
                            Title = "Network engineering"
                        },
                        new
                        {
                            Id = 6,
                            Title = "Data analytics"
                        });
                });

            modelBuilder.Entity("DAL.Entities.Rating", b =>
                {
                    b.HasOne("DAL.Entities.Student", "Student")
                        .WithMany("Ratings")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.Subject", "Subject")
                        .WithMany("Ratings")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("DAL.Entities.Student", b =>
                {
                    b.HasOne("DAL.Entities.Group", "Group")
                        .WithMany("Students")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Group");
                });

            modelBuilder.Entity("DAL.Entities.Group", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("DAL.Entities.Student", b =>
                {
                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("DAL.Entities.Subject", b =>
                {
                    b.Navigation("Ratings");
                });
#pragma warning restore 612, 618
        }
    }
}
