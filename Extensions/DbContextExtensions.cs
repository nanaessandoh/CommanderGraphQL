using CommanderGraphQL.Data;
using CommanderGraphQL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CommanderGraphQL.Extensions
{
    public static class DbContextExtensions
    {
        public static IServiceCollection AddCommanderDBContext(this IServiceCollection services, IConfiguration config)
        {
            services.AddEntityFrameworkNpgsql()
                .AddDbContext<ICommanderDBContext, CommanderDBContext>(options =>
                options.UseNpgsql(config.GetConnectionString("CommanderConnection")), ServiceLifetime.Scoped);

            return services;
        }
    }
}