using RocketAuction.API.Communication.Requests;
using RocketAuction.API.Entities;
using RocketAuction.API.Repositories;
using RocketAuction.API.Services;

namespace RocketAuction.API.UseCases.Offers.CreateOffer;

public class CreateOfferUseCase
{
    private readonly LoggedUser _loggedUser;
    public CreateOfferUseCase(LoggedUser loggedUser) => _loggedUser = loggedUser;

    public int Execute(int itemId, RequestCreateOfferJson request)
    {
        var repository = new RocketAuctionDbContext();

        var user = _loggedUser.User();

        var offer = new Offer
        {
            CreatedOn = DateTime.Now,
            ItemId = itemId,
            Price = request.Price,
            UserId = user.Id
        };

        repository.Offers.Add(offer);

        repository.SaveChanges();

        return offer.Id;
    }
}
