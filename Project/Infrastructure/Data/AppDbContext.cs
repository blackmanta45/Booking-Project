using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Core.Entities;
using Core.Entities.Base;
using Infrastructure.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class AppDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Hotel> Hotels { get; set; }
    public DbSet<HotelPicture> HotelPictures { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<RoomType> RoomTypes { get; set; }
    public DbSet<RoomPrice> RoomPrices { get; set; }
    public DbSet<Occupation> Occupations { get; set; }
    public new DbSet<User> Users { get; set; }
    public DbSet<UserPicture> UserPictures { get; set; }
    public DbSet<History> History { get; set; }
    public DbSet<Picture> Pictures { get; set; }

    public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
    {
        var modified = this.ChangeTracker.Entries<BaseEntity>().Where(e => e.State == EntityState.Modified).ToList();

        modified.ForEach(e =>
        {
            e.Property(x => x.ModifiedAt).CurrentValue = DateTime.Now;
        });

        return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.SeedRoomTypes();
        modelBuilder.SeedUser();
        modelBuilder.SeedHotels();
        modelBuilder.SeedRoles();
    }
}