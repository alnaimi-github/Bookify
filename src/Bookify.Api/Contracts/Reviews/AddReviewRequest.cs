namespace Bookify.Api.Contracts.Reviews;

public sealed record AddReviewRequest(Guid BookingId, int Rating, string Comment);