using RocketAuction.API.Contracts;
using RocketAuction.API.Entities;

namespace RocketAuction.API.Repositories.DataAccess;

public class OfferRepository : IOfferRepository
{
    private readonly RocketAuctionDbContext _dbContext;

    public OfferRepository(RocketAuctionDbContext dbContext) => _dbContext = dbContext;

    public void Add(Offer offer)
    {
        _dbContext.Offers.Add(offer);

        _dbContext.SaveChanges();
    }
}
