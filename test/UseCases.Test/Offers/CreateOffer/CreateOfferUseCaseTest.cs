using Bogus;
using FluentAssertions;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using Moq;
using RocketAuction.API.Communication.Requests;
using RocketAuction.API.Contracts;
using RocketAuction.API.Entities;
using RocketAuction.API.Services;
using RocketAuction.API.UseCases.Offers.CreateOffer;

namespace UseCases.Test.Offers.CreateOffer;

public class CreateOfferUseCaseTest
{
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    public void Success(int itemId)
    {
        //ARRANGE
        var request = new Faker<RequestCreateOfferJson>()
            .RuleFor(req => req.Price, f => f.Random.Decimal(1, 700)).Generate();

        var offerRepository = new Mock<IOfferRepository>();
        var loggedUser = new Mock<ILoggedUser>();
        loggedUser.Setup(i => i.User()).Returns(new User());

        var useCase = new CreateOfferUseCase(loggedUser.Object, offerRepository.Object);

        // ACT
        var act = () => useCase.Execute(itemId, request);
        
        // ASSERT
        act.Should().NotThrow();
    }
}
