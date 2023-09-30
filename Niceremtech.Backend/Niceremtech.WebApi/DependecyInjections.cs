using DbTests;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using NiceRemtech.Persistence.DbServise;

namespace Niceremtech.WebApi
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServisesWithIOptionConfigure ( this IServiceCollection services, WebApplicationBuilder builder)
        {
            //services.Configure<DbCredential> (builder.Configuration.GetSection("DbCredential"));
            return services;
        }
    }
}
