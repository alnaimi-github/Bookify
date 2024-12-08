using Bookify.Application.Abstractions.Messaging;

namespace Bookify.Application.Bookings.GetBooking;

public record GetBookingQuery(Guid BookingId) : IQuery<BookingResponse>
{
    public string CacheKey => $"bookings-{BookingId}";

    public virtual TimeSpan? Expiration => null;
}