using Bookify.Application.Abstractions.Email;
using Bookify.Domain.Bookings.Events;
using Bookify.Domain.Bookings.Interfaces;
using Bookify.Domain.Users.Interfaces;
using MediatR;

namespace Bookify.Application.Bookings.ReserveBooking;


internal sealed class BookingReservedDomainEventHandler(
    IBookingRepository bookingRepository,
    IUserRepository userRepository,
    IEmailService emailService)
    : INotificationHandler<BookingReservedDomainEvent>
{
    public async Task Handle(
        BookingReservedDomainEvent notification, 
        CancellationToken cancellationToken)
    {
        var booking = await bookingRepository.GetByIdAsync(notification.BookingId,
            cancellationToken);

        if (booking is null)
        {
            return;
        }

        var user = await userRepository.GetByIdAsync(booking.UserId, cancellationToken);

        if (user is null)
        {
            return;
        }

        await emailService.SendAsync(
            user.Email,
            "Booking reserved!",
            "You have 10 minutes to confirm this booking");
    }
}
