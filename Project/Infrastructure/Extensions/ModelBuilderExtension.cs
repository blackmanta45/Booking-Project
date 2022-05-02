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
                    Id = new Guid("d4ae2886-2cd6-480e-9c41-52c7295c4756"),
                    People = AvailableRoomSize.Person1,
                    DefaultPrice = 100,
                    Stars = 1
                },
                new RoomType
                {
                    Id = new Guid("6b851411-60ea-4f29-ab6e-431006c056fb"),
                    People = AvailableRoomSize.Person2,
                    DefaultPrice = 100,
                    Stars = 1
                },
                new RoomType
                {
                    Id = new Guid("94cb77a0-48a3-4dc7-bdb2-4119ff66e66e"),
                    People = AvailableRoomSize.Person3,
                    DefaultPrice = 140,
                    Stars = 1
                },
                new RoomType
                {
                    Id = new Guid("b73ed71b-a736-4428-88bc-bf1526262430"),
                    People = AvailableRoomSize.Person4,
                    DefaultPrice = 175,
                    Stars = 1
                },
                new RoomType
                {
                    Id = new Guid("5883f53b-0dc8-4fb3-b0b0-702742ab836b"),
                    People = AvailableRoomSize.Person5,
                    DefaultPrice = 250,
                    Stars = 1
                },
                new RoomType
                {
                    Id = new Guid("df7f20c3-852b-4582-90a0-c9f79247bd63"),
                    People = AvailableRoomSize.Person6,
                    DefaultPrice = 300,
                    Stars = 1
                },
                new RoomType
                {
                    Id = new Guid("854a3dd6-cfc7-4cae-805b-ec16956c3b80"),
                    People = AvailableRoomSize.Person1,
                    DefaultPrice = 200,
                    Stars = 2
                },
                new RoomType
                {
                    Id = new Guid("e3c73520-cbaf-46b9-88fc-12787f5921e4"),
                    People = AvailableRoomSize.Person2,
                    DefaultPrice = 200,
                    Stars = 2
                },
                new RoomType
                {
                    Id = new Guid("cc313a09-2902-4c9b-b5a2-6910810a843c"),
                    People = AvailableRoomSize.Person3,
                    DefaultPrice = 240,
                    Stars = 2
                },
                new RoomType
                {
                    Id = new Guid("89307e4d-c8b6-43c2-a495-7623ed9e58c6"),
                    People = AvailableRoomSize.Person4,
                    DefaultPrice = 275,
                    Stars = 2
                },
                new RoomType
                {
                    Id = new Guid("dbb65294-0250-4cfa-921b-14bbbab5167e"),
                    People = AvailableRoomSize.Person5,
                    DefaultPrice = 350,
                    Stars = 2
                },
                new RoomType
                {
                    Id = new Guid("5dfa4292-8bff-4710-9253-b0dddd97f687"),
                    People = AvailableRoomSize.Person6,
                    DefaultPrice = 400,
                    Stars = 2
                },
                new RoomType
                {
                    Id = new Guid("7fba7445-fd81-4e16-bd27-e05f53a830f4"),
                    People = AvailableRoomSize.Person1,
                    DefaultPrice = 300,
                    Stars = 3
                },
                new RoomType
                {
                    Id = new Guid("86c9336f-8887-4efa-a9c8-afcb29a8b9e9"),
                    People = AvailableRoomSize.Person2,
                    DefaultPrice = 300,
                    Stars = 3
                },
                new RoomType
                {
                    Id = new Guid("ddfd646e-057f-4a10-afbb-2aa79eea92b4"),
                    People = AvailableRoomSize.Person3,
                    DefaultPrice = 340,
                    Stars = 3
                },
                new RoomType
                {
                    Id = new Guid("21e49e4c-73be-43db-8ab2-4cffa4b7ffd9"),
                    People = AvailableRoomSize.Person4,
                    DefaultPrice = 375,
                    Stars = 3
                },
                new RoomType
                {
                    Id = new Guid("523c3d94-887d-40b0-a31a-dfd2273ebc61"),
                    People = AvailableRoomSize.Person5,
                    DefaultPrice = 450,
                    Stars = 3
                },
                new RoomType
                {
                    Id = new Guid("1e10ce12-421f-411b-9673-cc9b745458a5"),
                    People = AvailableRoomSize.Person6,
                    DefaultPrice = 500,
                    Stars = 3
                },
                new RoomType
                {
                    Id = new Guid("bb3e5a25-d7ec-4da3-baf0-b7e52476d542"),
                    People = AvailableRoomSize.Person1,
                    DefaultPrice = 400,
                    Stars = 4
                },
                new RoomType
                {
                    Id = new Guid("8db8586d-c284-44a9-9a3b-f789810d84e5"),
                    People = AvailableRoomSize.Person2,
                    DefaultPrice = 400,
                    Stars = 4
                },
                new RoomType
                {
                    Id = new Guid("9aef0aa4-c0b0-4e8e-b4a2-a1c03bddd105"),
                    People = AvailableRoomSize.Person3,
                    DefaultPrice = 440,
                    Stars = 4
                },
                new RoomType
                {
                    Id = new Guid("80f76308-a398-438a-b155-b4bc8a196620"),
                    People = AvailableRoomSize.Person4,
                    DefaultPrice = 475,
                    Stars = 4
                },
                new RoomType
                {
                    Id = new Guid("5cfdeff2-dd9d-4bce-a6ca-bc9d386a3765"),
                    People = AvailableRoomSize.Person5,
                    DefaultPrice = 550,
                    Stars = 4
                },
                new RoomType
                {
                    Id = new Guid("5ac314fa-b312-403b-a1bb-63fe7a28250c"),
                    People = AvailableRoomSize.Person6,
                    DefaultPrice = 600,
                    Stars = 4
                },
                new RoomType
                {
                    Id = new Guid("254c2247-fc55-40b7-9e37-e2a8ca0853ab"),
                    People = AvailableRoomSize.Person1,
                    DefaultPrice = 500,
                    Stars = 5
                },
                new RoomType
                {
                    Id = new Guid("81a63fab-a7d8-4236-aa08-411988901b92"),
                    People = AvailableRoomSize.Person2,
                    DefaultPrice = 500,
                    Stars = 5
                },
                new RoomType
                {
                    Id = new Guid("c5c8778a-0e36-4e8a-bf9d-68aeef0ddd33"),
                    People = AvailableRoomSize.Person3,
                    DefaultPrice = 540,
                    Stars = 5
                },
                new RoomType
                {
                    Id = new Guid("9d56ebc4-aff9-4b3a-a4b3-68f26bedc756"),
                    People = AvailableRoomSize.Person4,
                    DefaultPrice = 575,
                    Stars = 5
                },
                new RoomType
                {
                    Id = new Guid("3ae180cb-6baa-46e9-b246-320436538be2"),
                    People = AvailableRoomSize.Person5,
                    DefaultPrice = 650,
                    Stars = 5
                },
                new RoomType
                {
                    Id = new Guid("cb9804e5-8db6-40c0-98fd-00bdda8d97a4"),
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
                ShortDescription = "AA",
                Latitude = 46,
                Longitude = 25,
                Quality = 5
            }, new Hotel
            {
                Id = new Guid("b8dc0bdc-fda1-4e21-b485-8d88308f3bbe"),
                IsDeleted = false,
                Name = "bbb",
                Description = "BBBB",
                ShortDescription = "BB",
                Latitude = 44.31M,
                Longitude = 23.84M,
                Quality = 4
            }, new Hotel
            {
                Id = new Guid("dfe5b40c-0a3d-4ee9-8898-a80bcb1d584c"),
                IsDeleted = false,
                Name = "bbb",
                Description = "BBBB",
                ShortDescription = "BB",
                Latitude = 44.31M,
                Longitude = 23.84M,
                Quality = 3
            }, new Hotel
            {
                Id = new Guid("048b1f87-b7c9-4ccf-af0f-5cb29ddebc78"),
                IsDeleted = false,
                Name = "ccc",
                Description = "CCCC",
                ShortDescription = "CC",
                Latitude = 44.31M,
                Longitude = 23.84M,
                Quality = 2
            }, new Hotel
            {
                Id = new Guid("2f2fe0de-d277-4852-8fb4-2dceac60a5fd"),
                IsDeleted = false,
                Name = "ddd",
                Description = "DDDD",
                ShortDescription = "DD",
                Latitude = 44.31M,
                Longitude = 23.84M,
                Quality = 1
            });
    }
}