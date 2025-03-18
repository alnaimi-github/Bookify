using Microsoft.Extensions.Caching.Distributed;

namespace Bookify.Infrastructure.Caching;

public static class CacheOptions
{ 
    public static DistributedCacheEntryOptions DefaultCacheOptions => new()
    {
        AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(1)
    };

    public static DistributedCacheEntryOptions Create(TimeSpan? expiration) =>
        expiration is null
            ? DefaultCacheOptions
            : new DistributedCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = expiration
            };
}