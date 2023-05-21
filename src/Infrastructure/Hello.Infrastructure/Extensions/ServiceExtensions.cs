using Hello.Application.Repository;
using Hello.Infrastructure.Repository;
using Hello.Infrastructure.Store;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Hello.Infrastructure.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<StoreContext>(options =>
                options.UseSqlite(connectionString));

            // other infrastructure services
            services.AddScoped<IHelloRepository, HelloRepository>();

            return services;
        }
    }
}