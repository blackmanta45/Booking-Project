using System;
using Core.Common.Enums;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void SeedRoomTypes(this ModelBuilder modelBuilder) =>
            modelBuilder.Entity<RoomType>().HasData(
                new RoomType
                {
                    People = AvailableRoomSize.Person1,
                    DefaultPrice = 100,
                    Stars = 1
                },
                new RoomType
                {
                    People = AvailableRoomSize.Person2,
                    DefaultPrice = 100,
                    Stars = 1
                },
                new RoomType
                {
                    People = AvailableRoomSize.Person3,
                    DefaultPrice = 140,
                    Stars = 1
                },
                new RoomType
                {
                    People = AvailableRoomSize.Person4,
                    DefaultPrice = 175,
                    Stars = 1
                },
                new RoomType
                {
                    People = AvailableRoomSize.Person5,
                    DefaultPrice = 250,
                    Stars = 1
                },
                new RoomType
                {
                    People = AvailableRoomSize.Person6,
                    DefaultPrice = 300,
                    Stars = 1
                },
                new RoomType
                {
                    People = AvailableRoomSize.Person1,
                    DefaultPrice = 200,
                    Stars = 2
                },
                new RoomType
                {
                    People = AvailableRoomSize.Person2,
                    DefaultPrice = 200,
                    Stars = 2
                },
                new RoomType
                {
                    People = AvailableRoomSize.Person3,
                    DefaultPrice = 240,
                    Stars = 2
                },
                new RoomType
                {
                    People = AvailableRoomSize.Person4,
                    DefaultPrice = 275,
                    Stars = 2
                },
                new RoomType
                {
                    People = AvailableRoomSize.Person5,
                    DefaultPrice = 350,
                    Stars = 2
                },
                new RoomType
                {
                    People = AvailableRoomSize.Person6,
                    DefaultPrice = 400,
                    Stars = 2
                },
                new RoomType
                {
                    People = AvailableRoomSize.Person1,
                    DefaultPrice = 300,
                    Stars = 3
                },
                new RoomType
                {
                    People = AvailableRoomSize.Person2,
                    DefaultPrice = 300,
                    Stars = 3
                },
                new RoomType
                {
                    People = AvailableRoomSize.Person3,
                    DefaultPrice = 340,
                    Stars = 3
                },
                new RoomType
                {
                    People = AvailableRoomSize.Person4,
                    DefaultPrice = 375,
                    Stars = 3
                },
                new RoomType
                {
                    People = AvailableRoomSize.Person5,
                    DefaultPrice = 450,
                    Stars = 3
                },
                new RoomType
                {
                    People = AvailableRoomSize.Person6,
                    DefaultPrice = 500,
                    Stars = 3
                },
                new RoomType
                {
                    People = AvailableRoomSize.Person1,
                    DefaultPrice = 400,
                    Stars = 4
                },
                new RoomType
                {
                    People = AvailableRoomSize.Person2,
                    DefaultPrice = 400,
                    Stars = 4
                },
                new RoomType
                {
                    People = AvailableRoomSize.Person3,
                    DefaultPrice = 440,
                    Stars = 4
                },
                new RoomType
                {
                    People = AvailableRoomSize.Person4,
                    DefaultPrice = 475,
                    Stars = 4
                },
                new RoomType
                {
                    People = AvailableRoomSize.Person5,
                    DefaultPrice = 550,
                    Stars = 4
                },
                new RoomType
                {
                    People = AvailableRoomSize.Person6,
                    DefaultPrice = 600,
                    Stars = 4
                },
                new RoomType
                {
                    People = AvailableRoomSize.Person1,
                    DefaultPrice = 500,
                    Stars = 5
                },
                new RoomType
                {
                    People = AvailableRoomSize.Person2,
                    DefaultPrice = 500,
                    Stars = 5
                },
                new RoomType
                {
                    People = AvailableRoomSize.Person3,
                    DefaultPrice = 540,
                    Stars = 5
                },
                new RoomType
                {
                    People = AvailableRoomSize.Person4,
                    DefaultPrice = 575,
                    Stars = 5
                },
                new RoomType
                {
                    People = AvailableRoomSize.Person5,
                    DefaultPrice = 650,
                    Stars = 5
                },
                new RoomType
                {
                    People = AvailableRoomSize.Person6,
                    DefaultPrice = 700,
                    Stars = 5
                });

        public static void SeedUser(this ModelBuilder modelBuilder) =>
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = new Guid("ac365e29-7f22-472f-bd22-ce7fab2e48f2"),
                IsDeleted = false,
                Name = "George",
                Surname = "George",
                DateOfBirth = DateTime.Now.AddYears(-18),
                Email = "georgegeorge@george.com",
                Phone = "0767676767",
                Gender = Gender.ApacheHelicopter
            });

        public static void SeedHotels(this ModelBuilder modelBuilder) =>
            modelBuilder.Entity<Hotel>().HasData(new Hotel
            {
                Id = new Guid("3bbd424c-ecb4-45b0-9aa5-07f7b983e9e6"),
                IsDeleted = false,
                Name = "aaa",
                Description = "AAAA",
                Latitude = 46,
                Longitude = 25,
                Quality = 4,
                CreatedBy = new User
                {
                    Id = new Guid("ac365e29-7f22-472f-bd22-ce7fab2e48f2"),
                    IsDeleted = false,
                    Name = "George",
                    Surname = "George",
                    DateOfBirth = DateTime.Now.AddYears(-18),
                    Email = "georgegeorge@george.com",
                    Phone = "0767676767",
                    Gender = Gender.ApacheHelicopter
                },
                ModifiedBy = new User
                {
                    Id = new Guid("ac365e29-7f22-472f-bd22-ce7fab2e48f2"),
                    IsDeleted = false,
                    Name = "George",
                    Surname = "George",
                    DateOfBirth = DateTime.Now.AddYears(-18),
                    Email = "georgegeorge@george.com",
                    Phone = "0767676767",
                    Gender = Gender.ApacheHelicopter
                }
            });
    }
}