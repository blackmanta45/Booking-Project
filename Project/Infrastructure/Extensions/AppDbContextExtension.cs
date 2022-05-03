using System;
using System.IO;
using System.Threading.Tasks;
using Core.Entities;
using Infrastructure.Data;

namespace Infrastructure.Extensions;

public static class AppDbContextExtension
{
    public static async Task SeedRemainingData(this AppDbContext dbContext)
    {
        if (await dbContext.SeedRooms())
            return;

        await dbContext.SeedHotelPictures();
        await dbContext.SeedUserPictures();
        await dbContext.SeedReviews();
    }

    private static async Task<bool> SeedRooms(this AppDbContext dbContext)
    {
        var roomType = await dbContext.RoomTypes.FindAsync(new Guid("254c2247-fc55-40b7-9e37-e2a8ca0853ab"));
        var hotel = await dbContext.Hotels.FindAsync(new Guid("2F2FE0DE-D277-4852-8FB4-2DCEAC60A5FD"));

        if (await dbContext.Rooms.FindAsync(new Guid("3bbd424c-ecb4-45b0-9aa5-07f7b983e9e6")) is not null)
            return true;

        dbContext.Rooms.AddRange(new Room
        {
            Id = new Guid("3bbd424c-ecb4-45b0-9aa5-07f7b983e9e6"),
            IsDeleted = false,
            Type = roomType,
            Hotel = hotel
        }, new Room
        {
            Id = new Guid("1a6605b0-4dfb-427f-b9f7-50944fbd2c17"),
            IsDeleted = false,
            Type = roomType,
            Hotel = hotel
        }, new Room
        {
            Id = new Guid("7b824d43-0e62-4ac2-a6ac-40c9fa5f5bad"),
            IsDeleted = false,
            Type = roomType,
            Hotel = hotel
        }, new Room
        {
            Id = new Guid("90894a6e-b7ac-40aa-91f3-8501282b20d1"),
            IsDeleted = false,
            Type = roomType,
            Hotel = hotel
        });

        roomType = await dbContext.RoomTypes.FindAsync(new Guid("254c2247-fc55-40b7-9e37-e2a8ca0853ab"));
        hotel = await dbContext.Hotels.FindAsync(new Guid("048B1F87-B7C9-4CCF-AF0F-5CB29DDEBC78"));
        dbContext.Rooms.AddRange(new Room
        {
            Id = new Guid("40c076f6-a549-4dcc-828a-8713bf2dd3eb"),
            IsDeleted = false,
            Type = roomType,
            Hotel = hotel
        }, new Room
        {
            Id = new Guid("d2a13c6d-3604-4fff-8534-65befaacd569"),
            IsDeleted = false,
            Type = roomType,
            Hotel = hotel
        });

        roomType = await dbContext.RoomTypes.FindAsync(new Guid("6B851411-60EA-4F29-AB6E-431006C056FB"));
        hotel = await dbContext.Hotels.FindAsync(new Guid("048B1F87-B7C9-4CCF-AF0F-5CB29DDEBC78"));
        dbContext.Rooms.AddRange(new Room
        {
            Id = new Guid("340293ff-29d8-48cb-ac9e-77f0449461ae"),
            IsDeleted = false,
            Type = roomType,
            Hotel = hotel
        }, new Room
        {
            Id = new Guid("ac97f1da-ab91-463e-b183-06cefa1b944f"),
            IsDeleted = false,
            Type = roomType,
            Hotel = hotel
        });

        await dbContext.SaveChangesAsync();
        return false;
    }

    private static async Task SeedHotelPictures(this AppDbContext dbContext)
    {
        var n = new Random().Next(1, 31);
        var hotel = await dbContext.Hotels.FindAsync(new Guid("2F2FE0DE-D277-4852-8FB4-2DCEAC60A5FD"));
        for (var i = 1; i <= n; i++)
        {
            var picture = new Picture
            {
                Id = Guid.NewGuid(),
                Bytes = await File.ReadAllBytesAsync(@$"../Presentation/wwwroot/img/hotel-list-pictures/{new Random().Next(0, 31)}.jpeg")
            };

            await dbContext.Pictures.AddAsync(picture);
            await dbContext.SaveChangesAsync();

            await dbContext.HotelPictures.AddAsync(new HotelPicture
            {
                Id = default,
                IsDeleted = false,
                Picture = picture,
                Hotel = hotel
            });
        }

        n = new Random().Next(1, 31);
        hotel = await dbContext.Hotels.FindAsync(new Guid("048B1F87-B7C9-4CCF-AF0F-5CB29DDEBC78"));
        for (var i = 1; i <= n; i++)
        {
            var picture = new Picture
            {
                Id = Guid.NewGuid(),
                Bytes = await File.ReadAllBytesAsync(@$"../Presentation/wwwroot/img/hotel-list-pictures/{new Random().Next(0, 31)}.jpeg")
            };

            await dbContext.Pictures.AddAsync(picture);
            await dbContext.SaveChangesAsync();

            await dbContext.HotelPictures.AddAsync(new HotelPicture
            {
                Id = default,
                IsDeleted = false,
                Picture = picture,
                Hotel = hotel
            });
        }
    }

    private static async Task SeedUserPictures(this AppDbContext dbContext)
    {
        var picture = new Picture
        {
            Id = Guid.NewGuid(),
            Bytes = await File.ReadAllBytesAsync(@$"../Presentation/wwwroot/img/reviews-pictures/{new Random().Next(0, 31)}.jpeg")
        };

        await dbContext.Pictures.AddAsync(picture);
        await dbContext.SaveChangesAsync();

        var userPicture = new UserPicture
        {
            Id = Guid.NewGuid(),
            IsDeleted = false,
            Picture = picture
        };
        await dbContext.UserPictures.AddAsync(userPicture);

        var user = await dbContext.Users.FindAsync(new Guid("ac365e29-7f22-472f-bd22-ce7fab2e48f2"));
        if (user is not null)
        {
            user.Picture = userPicture;
            dbContext.Users.Update(user);
        }

        await dbContext.SaveChangesAsync();
    }

    private static async Task SeedReviews(this AppDbContext dbContext)
    {
        var user = await dbContext.Users.FindAsync(new Guid("ac365e29-7f22-472f-bd22-ce7fab2e48f2"));
        var hotel = await dbContext.Hotels.FindAsync(new Guid("2F2FE0DE-D277-4852-8FB4-2DCEAC60A5FD"));

        var n = new Random().Next(1, 6);
        for (var i = 1; i <= n; i++)
        {
            var review = new Review
            {
                Id = Guid.NewGuid(),
                Value = new Random().Next(1, 6),
                Description = "This is a test description 1",
                Hotel = hotel,
                User = user
            };

            await dbContext.Reviews.AddAsync(review);
            await dbContext.SaveChangesAsync();
        }
        hotel = await dbContext.Hotels.FindAsync(new Guid("048B1F87-B7C9-4CCF-AF0F-5CB29DDEBC78"));

        n = new Random().Next(1, 6);
        for (var i = 1; i <= n; i++)
        {
            var review = new Review
            {
                Id = Guid.NewGuid(),
                Value = new Random().Next(1, 6),
                Description = "This is a test description 2",
                Hotel = hotel,
                User = user
            };

            await dbContext.Reviews.AddAsync(review);
            await dbContext.SaveChangesAsync();
        }
    }
}