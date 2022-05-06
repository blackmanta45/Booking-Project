using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Core.Entities;
using Core.Entities.Base;
using Infrastructure.Extensions;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class AppDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
{
    private readonly IHttpContextAccessor httpContextAccessor;
    public AppDbContext(DbContextOptions<AppDbContext> options, IHttpContextAccessor httpContextAccessor) : base(options)
    {
        this.httpContextAccessor = httpContextAccessor;
    }
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

    public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
    {
        var modified = this.ChangeTracker.Entries<BaseEntity>().Where(e => e.State == EntityState.Modified).ToList();
        var added = this.ChangeTracker.Entries<BaseEntity>().Where(e => e.State == EntityState.Added).ToList();
        User user = null;
        if (Guid.TryParse(this.httpContextAccessor.HttpContext?.User.Identity.GetUserId(), out var userId))
        {
            user = await this.Users.FindAsync(userId);
        }

        modified.ForEach(e =>
        {
            e.Property(x => x.ModifiedAt).CurrentValue = DateTime.Now;
            e.Reference(x => x.ModifiedBy).CurrentValue = user ?? e.Reference(x => x.ModifiedBy).CurrentValue;
        });

        added.ForEach(e =>
        {
            e.Property(x => x.CreatedAt).CurrentValue = DateTime.Now;
            e.Reference(x => x.CreatedBy).CurrentValue = user ?? e.Reference(x => x.ModifiedBy).CurrentValue;
            e.Property(x => x.ModifiedAt).CurrentValue = DateTime.Now;
            e.Reference(x => x.ModifiedBy).CurrentValue = user ?? e.Reference(x => x.ModifiedBy).CurrentValue;
        });

        return await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.SeedRoomTypes();
        modelBuilder.SeedHotels();
        //modelBuilder.SeedRoles();
    }
}