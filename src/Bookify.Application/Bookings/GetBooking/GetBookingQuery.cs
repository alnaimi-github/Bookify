using Bookify.Application.Abstractions.Caching;
using Bookify.Application.Abstractions.Messaging;

namespace Bookify.Application.Bookings.GetBooking;

public record GetBookingQuery(Guid BookingId) : ICachedQuery<BookingResponse>
{
    public string CacheKey => $"bookings-{BookingId}";

    public TimeSpan? Expiration => null;
}