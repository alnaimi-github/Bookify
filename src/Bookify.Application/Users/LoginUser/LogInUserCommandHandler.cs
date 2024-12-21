using Bookify.Application.Abstractions.Authentication;
using Bookify.Application.Abstractions.Messaging;
using Bookify.Domain.Abstractions;
using Bookify.Domain.Users;

namespace Bookify.Application.Users.LoginUser;

internal sealed class LogInUserCommandHandler(IJwtService jwtService)
    : ICommandHandler<LogInUserCommand, AccessTokenResponse>
{
    public async Task<Result<AccessTokenResponse>> Handle(
        LogInUserCommand request,
        CancellationToken cancellationToken)
    {
        var result = await jwtService.GetAccessTokenAsync(
            request.Email,
            request.Password,
            cancellationToken);

        if (result.IsFailure)
        {
            return Result.Failure<AccessTokenResponse>(UserErrors.InvalidCredentials);
        }

        return new AccessTokenResponse(result.Value);
    }
}