using Domain.Aggregates.DraftFunnels.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace Repository.Base
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMongoDbs(configuration);
            services.AddScoped<IDraftFunnelRepository, DraftFunnelRepository>();


            return services;
        }

        private static IServiceCollection AddMongoDbs(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionSting = configuration["MongoDb:ConnectionString"];
            var mongoClient = new MongoClient(connectionSting);
            services.AddSingleton(mongoClient);
            return services;
        }
    }
}
