using Microsoft.EntityFrameworkCore;
using RocketAuction.API.Contracts;
using RocketAuction.API.Entities;

namespace RocketAuction.API.Repositories.DataAccess;

public class AuctionRepository : IAuctionRepository
{
    private readonly RocketAuctionDbContext _dbContext;

    public AuctionRepository(RocketAuctionDbContext dbContext) => _dbContext = dbContext;

    public Auction? GetCurrent()
    {
        var today = DateTime.Now;

        return _dbContext
            .Auctions
            .Include(auction => auction.Items)
            .FirstOrDefault(auction => today >= auction.Starts && today <= auction.Ends);
    }
}
