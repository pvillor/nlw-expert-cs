using Microsoft.EntityFrameworkCore;
using RocketAuction.API.Entities;

namespace RocketAuction.API.Repositories;

public class RocketAuctionDbContext : DbContext
{
    public DbSet<Auction> Auctions { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source=C:\Users\paulo.guerra\Documents\rocketseat\nlw-expert\csharp\auctionDbNLW.db");
    }
}
