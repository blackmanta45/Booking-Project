﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Presentation.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Core.Entities.History", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("HotelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("People")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.HasIndex("UserId");

                    b.ToTable("History");
                });

            modelBuilder.Entity("Core.Entities.Hotel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Latitude")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Longitude")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ModifiedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quality")
                        .HasColumnType("int");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("ModifiedById");

                    b.ToTable("Hotel");
                });

            modelBuilder.Entity("Core.Entities.HotelPicture", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("HotelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PictureId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.HasIndex("PictureId");

                    b.ToTable("HotelPicture");
                });

            modelBuilder.Entity("Core.Entities.Occupation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("HotelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ModifiedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoomId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("HotelId");

                    b.HasIndex("ModifiedById");

                    b.HasIndex("RoomId");

                    b.ToTable("Occupation");
                });

            modelBuilder.Entity("Core.Entities.Picture", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("Bytes")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ModifiedById")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("ModifiedById");

                    b.ToTable("Picture");
                });

            modelBuilder.Entity("Core.Entities.Review", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<Guid>("HotelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.HasIndex("UserId");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("Core.Entities.Room", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("HotelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ModifiedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TypeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("HotelId");

                    b.HasIndex("ModifiedById");

                    b.HasIndex("TypeId");

                    b.ToTable("Room");
                });

            modelBuilder.Entity("Core.Entities.RoomPrice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ModifiedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("RoomId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("ModifiedById");

                    b.HasIndex("RoomId");

                    b.ToTable("RoomPrice");
                });

            modelBuilder.Entity("Core.Entities.RoomType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("DefaultPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("People")
                        .HasColumnType("int");

                    b.Property<int>("Stars")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("RoomType");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7229b300-3b67-4471-8946-d9e6a05002c6"),
                            DefaultPrice = 100m,
                            People = 1,
                            Stars = 1
                        },
                        new
                        {
                            Id = new Guid("7fa8eedc-351f-4a26-b1df-1c4737e2277a"),
                            DefaultPrice = 100m,
                            People = 2,
                            Stars = 1
                        },
                        new
                        {
                            Id = new Guid("157cd66b-4b67-4baf-9dc0-4a62ae3a039e"),
                            DefaultPrice = 140m,
                            People = 3,
                            Stars = 1
                        },
                        new
                        {
                            Id = new Guid("3e2e1927-0c0d-4bb3-9f57-ed502c4e288b"),
                            DefaultPrice = 175m,
                            People = 4,
                            Stars = 1
                        },
                        new
                        {
                            Id = new Guid("1e03f289-2795-4ca4-8a89-9a457eb4ce52"),
                            DefaultPrice = 250m,
                            People = 5,
                            Stars = 1
                        },
                        new
                        {
                            Id = new Guid("b1a34bbf-b1dd-4e50-ac9d-6d9ecaab6113"),
                            DefaultPrice = 300m,
                            People = 6,
                            Stars = 1
                        },
                        new
                        {
                            Id = new Guid("1e410d19-8732-4a83-ac71-7127b8c00ea8"),
                            DefaultPrice = 200m,
                            People = 1,
                            Stars = 2
                        },
                        new
                        {
                            Id = new Guid("3385489d-c0f2-4b21-8b21-2baaa8ada757"),
                            DefaultPrice = 200m,
                            People = 2,
                            Stars = 2
                        },
                        new
                        {
                            Id = new Guid("e076bdc1-df60-4c95-8cb3-0416975da5d0"),
                            DefaultPrice = 240m,
                            People = 3,
                            Stars = 2
                        },
                        new
                        {
                            Id = new Guid("8f9ca21d-aba9-4034-a479-2c850764eef1"),
                            DefaultPrice = 275m,
                            People = 4,
                            Stars = 2
                        },
                        new
                        {
                            Id = new Guid("a382e0b0-1e17-47c4-921b-39968384824d"),
                            DefaultPrice = 350m,
                            People = 5,
                            Stars = 2
                        },
                        new
                        {
                            Id = new Guid("2b7578db-8d6e-4be4-8b47-6475e3cbbd1b"),
                            DefaultPrice = 400m,
                            People = 6,
                            Stars = 2
                        },
                        new
                        {
                            Id = new Guid("36869323-fc5e-46bf-b87b-105d9d1225c7"),
                            DefaultPrice = 300m,
                            People = 1,
                            Stars = 3
                        },
                        new
                        {
                            Id = new Guid("37c0ce04-0184-48ea-b1f4-b5a92bc4353a"),
                            DefaultPrice = 300m,
                            People = 2,
                            Stars = 3
                        },
                        new
                        {
                            Id = new Guid("3f38c435-c5e5-41e2-952f-4fb6884c6694"),
                            DefaultPrice = 340m,
                            People = 3,
                            Stars = 3
                        },
                        new
                        {
                            Id = new Guid("73caeb6a-6e67-4ab9-a36b-9827567168f5"),
                            DefaultPrice = 375m,
                            People = 4,
                            Stars = 3
                        },
                        new
                        {
                            Id = new Guid("1ee45d85-2d5f-47ab-aa92-50f091c1ea74"),
                            DefaultPrice = 450m,
                            People = 5,
                            Stars = 3
                        },
                        new
                        {
                            Id = new Guid("8f4b2ec0-3249-46f6-8950-e1c4ea91b0c0"),
                            DefaultPrice = 500m,
                            People = 6,
                            Stars = 3
                        },
                        new
                        {
                            Id = new Guid("a595ff56-72d6-40cd-b24b-febc963c6040"),
                            DefaultPrice = 400m,
                            People = 1,
                            Stars = 4
                        },
                        new
                        {
                            Id = new Guid("2e5c85d9-753e-4d48-a6e2-c2b17ad97870"),
                            DefaultPrice = 400m,
                            People = 2,
                            Stars = 4
                        },
                        new
                        {
                            Id = new Guid("c82a5eb3-e634-4b74-94f1-08126890da96"),
                            DefaultPrice = 440m,
                            People = 3,
                            Stars = 4
                        },
                        new
                        {
                            Id = new Guid("e1383a2a-0437-4899-9ff7-3186822efd84"),
                            DefaultPrice = 475m,
                            People = 4,
                            Stars = 4
                        },
                        new
                        {
                            Id = new Guid("7ff63d1f-dcc7-4b92-af2b-f4a44ddedabf"),
                            DefaultPrice = 550m,
                            People = 5,
                            Stars = 4
                        },
                        new
                        {
                            Id = new Guid("08b9f148-6599-4848-8486-6b28cde90389"),
                            DefaultPrice = 600m,
                            People = 6,
                            Stars = 4
                        },
                        new
                        {
                            Id = new Guid("96b4066f-c758-4655-97ef-2bb0f81a780a"),
                            DefaultPrice = 500m,
                            People = 1,
                            Stars = 5
                        },
                        new
                        {
                            Id = new Guid("3345ceee-4d0e-445e-ab4d-d9de860edb9a"),
                            DefaultPrice = 500m,
                            People = 2,
                            Stars = 5
                        },
                        new
                        {
                            Id = new Guid("4b0cbd97-7ea8-4970-8881-aad34c292fff"),
                            DefaultPrice = 540m,
                            People = 3,
                            Stars = 5
                        },
                        new
                        {
                            Id = new Guid("c374f512-ea45-4547-aa8f-c2a7ec975c29"),
                            DefaultPrice = 575m,
                            People = 4,
                            Stars = 5
                        },
                        new
                        {
                            Id = new Guid("b6655299-1d7c-42ca-87ca-730579fda317"),
                            DefaultPrice = 650m,
                            People = 5,
                            Stars = 5
                        },
                        new
                        {
                            Id = new Guid("e11cee64-0e8c-42ac-a661-319021efef4c"),
                            DefaultPrice = 700m,
                            People = 6,
                            Stars = 5
                        });
                });

            modelBuilder.Entity("Core.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<Guid?>("PictureId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PictureId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Core.Entities.UserPicture", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PictureId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PictureId");

                    b.ToTable("UserPicture");
                });

            modelBuilder.Entity("Core.Entities.History", b =>
                {
                    b.HasOne("Core.Entities.Hotel", "Hotel")
                        .WithMany("History")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.User", "User")
                        .WithMany("History")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Core.Entities.Hotel", b =>
                {
                    b.HasOne("Core.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("Core.Entities.User", "ModifiedBy")
                        .WithMany()
                        .HasForeignKey("ModifiedById");

                    b.Navigation("CreatedBy");

                    b.Navigation("ModifiedBy");
                });

            modelBuilder.Entity("Core.Entities.HotelPicture", b =>
                {
                    b.HasOne("Core.Entities.Hotel", "Hotel")
                        .WithMany("Pictures")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Picture", "Picture")
                        .WithMany()
                        .HasForeignKey("PictureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");

                    b.Navigation("Picture");
                });

            modelBuilder.Entity("Core.Entities.Occupation", b =>
                {
                    b.HasOne("Core.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("Core.Entities.Hotel", null)
                        .WithMany("Occupations")
                        .HasForeignKey("HotelId");

                    b.HasOne("Core.Entities.User", "ModifiedBy")
                        .WithMany()
                        .HasForeignKey("ModifiedById");

                    b.HasOne("Core.Entities.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatedBy");

                    b.Navigation("ModifiedBy");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Core.Entities.Picture", b =>
                {
                    b.HasOne("Core.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("Core.Entities.User", "ModifiedBy")
                        .WithMany()
                        .HasForeignKey("ModifiedById");

                    b.Navigation("CreatedBy");

                    b.Navigation("ModifiedBy");
                });

            modelBuilder.Entity("Core.Entities.Review", b =>
                {
                    b.HasOne("Core.Entities.Hotel", "Hotel")
                        .WithMany("Reviews")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.User", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Core.Entities.Room", b =>
                {
                    b.HasOne("Core.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("Core.Entities.Hotel", "Hotel")
                        .WithMany("Rooms")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.User", "ModifiedBy")
                        .WithMany()
                        .HasForeignKey("ModifiedById");

                    b.HasOne("Core.Entities.RoomType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatedBy");

                    b.Navigation("Hotel");

                    b.Navigation("ModifiedBy");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("Core.Entities.RoomPrice", b =>
                {
                    b.HasOne("Core.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("Core.Entities.User", "ModifiedBy")
                        .WithMany()
                        .HasForeignKey("ModifiedById");

                    b.HasOne("Core.Entities.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatedBy");

                    b.Navigation("ModifiedBy");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Core.Entities.User", b =>
                {
                    b.HasOne("Core.Entities.UserPicture", "Picture")
                        .WithMany()
                        .HasForeignKey("PictureId");

                    b.Navigation("Picture");
                });

            modelBuilder.Entity("Core.Entities.UserPicture", b =>
                {
                    b.HasOne("Core.Entities.Picture", "Picture")
                        .WithMany()
                        .HasForeignKey("PictureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Picture");
                });

            modelBuilder.Entity("Core.Entities.Hotel", b =>
                {
                    b.Navigation("History");

                    b.Navigation("Occupations");

                    b.Navigation("Pictures");

                    b.Navigation("Reviews");

                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("Core.Entities.User", b =>
                {
                    b.Navigation("History");

                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
