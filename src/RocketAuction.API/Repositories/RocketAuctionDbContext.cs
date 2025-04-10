using Microsoft.EntityFrameworkCore;
using RocketAuction.API.Entities;

namespace RocketAuction.API.Repositories;

public class RocketAuctionDbContext : DbContext
{
    public RocketAuctionDbContext(DbContextOptions options) : base(options) { }

    public DbSet<Auction> Auctions { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Offer> Offers { get; set; }
}
