using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Basket.Core;

public static class BasketModule
{
        public static IServiceCollection AddBasketModule(this IServiceCollection services,
            IConfiguration configuration)
        {
            return services;
        }
}