using Microsoft.Extensions.DependencyInjection;

namespace Domain.Base
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services)
        {
            return services;
        }
    }
}
