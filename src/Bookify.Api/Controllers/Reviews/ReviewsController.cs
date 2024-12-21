using Bookify.Api.Contracts.Reviews;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Bookify.Api.Controllers.Reviews;

[ApiController]
[Route("api/reviews")]
public class ReviewsController(ISender sender) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> AddReview(
        AddReviewRequest request,
        CancellationToken cancellationToken)
    {
        //var command = new AddReviewCommand(request.BookingId, request.Rating, request.Comment);

        //var result = await sender.Send(command, cancellationToken);

        //if (result.IsFailure)
        //{
        //    return BadRequest(result.Error);
        //}

        return Ok();
    }
}
