using RocketAuction.API.Entities;

namespace RocketAuction.API.Contracts;

public interface IOfferRepository
{
    public void Add(Offer offer);
}
