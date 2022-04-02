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
                    People = 2,
                    DefaultPrice = 100,
                    Stars = 1
                },
                new RoomType
                {
                    People = 3,
                    DefaultPrice = 140,
                    Stars = 1
                },
                new RoomType
                {
                    People = 4,
                    DefaultPrice = 175,
                    Stars = 1
                },
                new RoomType
                {
                    People = 5,
                    DefaultPrice = 250,
                    Stars = 1
                },
                new RoomType
                {
                    People = 6,
                    DefaultPrice = 300,
                    Stars = 1
                },
                new RoomType
                {
                    People = 2,
                    DefaultPrice = 200,
                    Stars = 2
                },
                new RoomType
                {
                    People = 3,
                    DefaultPrice = 240,
                    Stars = 2
                },
                new RoomType
                {
                    People = 4,
                    DefaultPrice = 275,
                    Stars = 2
                },
                new RoomType
                {
                    People = 5,
                    DefaultPrice = 350,
                    Stars = 2
                },
                new RoomType
                {
                    People = 6,
                    DefaultPrice = 400,
                    Stars = 2
                },
                new RoomType
                {
                    People = 2,
                    DefaultPrice = 300,
                    Stars = 3
                },
                new RoomType
                {
                    People = 3,
                    DefaultPrice = 340,
                    Stars = 3
                },
                new RoomType
                {
                    People = 4,
                    DefaultPrice = 375,
                    Stars = 3
                },
                new RoomType
                {
                    People = 5,
                    DefaultPrice = 450,
                    Stars = 3
                },
                new RoomType
                {
                    People = 6,
                    DefaultPrice = 500,
                    Stars = 3
                },
                new RoomType
                {
                    People = 2,
                    DefaultPrice = 400,
                    Stars = 4
                },
                new RoomType
                {
                    People = 3,
                    DefaultPrice = 440,
                    Stars = 4
                },
                new RoomType
                {
                    People = 4,
                    DefaultPrice = 475,
                    Stars = 4
                },
                new RoomType
                {
                    People = 5,
                    DefaultPrice = 550,
                    Stars = 4
                },
                new RoomType
                {
                    People = 6,
                    DefaultPrice = 600,
                    Stars = 4
                },
                new RoomType
                {
                    People = 2,
                    DefaultPrice = 500,
                    Stars = 5
                },
                new RoomType
                {
                    People = 3,
                    DefaultPrice = 540,
                    Stars = 5
                },
                new RoomType
                {
                    People = 4,
                    DefaultPrice = 575,
                    Stars = 5
                },
                new RoomType
                {
                    People = 5,
                    DefaultPrice = 650,
                    Stars = 5
                },
                new RoomType
                {
                    People = 6,
                    DefaultPrice = 700,
                    Stars = 5
                });
    }
}