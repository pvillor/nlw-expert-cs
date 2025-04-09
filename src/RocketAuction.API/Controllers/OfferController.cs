using Microsoft.AspNetCore.Mvc;
using RocketAuction.API.Communication.Requests;
using RocketAuction.API.Filters;
using RocketAuction.API.UseCases.Offers.CreateOffer;

namespace RocketAuction.API.Controllers;

[ServiceFilter(typeof(AuthenticationUserAttribute))]
public class OfferController : RocketAuctionBaseController
{
    [HttpPost()]
    [Route("{itemId}")]
    public IActionResult CreateOffer(
        [FromRoute] int itemId,
        [FromBody] RequestCreateOfferJson request,
        [FromServices] CreateOfferUseCase useCase)
    {
        var id = useCase.Execute(itemId, request);

        return Created(string.Empty, id);
    }
}
