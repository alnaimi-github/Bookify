# Bookify

Bookify is a C# application designed to help manage and organize book collections efficiently using Clean Architecture principles. This modular and maintainable architecture ensures that the application is scalable, testable, and easy to understand.

## Clean Architecture Principles Applied in Bookify

* **Separation of concerns**: The code is organized into different layers, each with a specific responsibility. For example, the `src/Bookify.Domain` directory contains domain entities and value objects, while the `src/Bookify.Application` directory (not shown) likely contains application logic.
* **Dependency inversion**: High-level modules do not depend on low-level modules. Instead, both depend on abstractions. For example, the `IUnitOfWork` interface in `src/Bookify.Domain/Abstractions/IUnitOfWork.cs` abstracts the persistence mechanism.
* **Domain-centric design**: The core business logic is encapsulated in the domain layer. For example, the `Apartment` class in `src/Bookify.Domain/Apartments/Apartment.cs` and the `Booking` class in `src/Bookify.Domain/Bookings/Booking.cs` contain the business rules and logic.
* **Use of value objects**: Value objects are used to represent concepts in the domain. For example, `Address` in `src/Bookify.Domain/Apartments/ValueObjects/Address.cs` and `Money` in `src/Bookify.Domain/Shared/Money.cs` are value objects that encapsulate specific domain concepts.
* **Event-driven architecture**: Domain events are used to signal changes in the state of the system. For example, the `BookingReservedDomainEvent` in `src/Bookify.Domain/Bookings/Events/BookingReservedDomainEvent.cs` is raised when a booking is reserved.
* **Testability**: The architecture promotes testability by isolating the business logic from external dependencies. For example, the `PricingService` in `src/Bookify.Domain/Bookings/Services/PricingService.cs` can be tested independently of the rest of the system.
