using RocketAuction.API.Entities;

namespace RocketAuction.API.Contracts;

public interface IAuctionRepository
{
    public Auction? GetCurrent();
}
