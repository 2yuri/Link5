using System;
using AgentBuddy.Infrastructure.Common;
using Link5.Infrastructure.Common;
using Link5.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Link5.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection ConfigureDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("PostgresConnection"))
            );

            services.AddTransient<IUnitOfWork, UnitOfWork>();


            return services;
        }
    }
}
