using Bookify.Domain.Shared;

namespace Bookify.Domain.Bookings.Services;

public sealed record PricingDetails(
    Money PriceForPeriod,
    Money CleaningFee,
    Money AmenitiesUpCharge,
    Money TotalPrice);