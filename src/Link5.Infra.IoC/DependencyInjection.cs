using System;
using AgentBuddy.Infra.Core.Repositories;
using Link5.Infra.Core.Context;
using Link5.Infra.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Link5.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection ConfigureDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("PgConn")));

            services.AddTransient<IUnitOfWork, UnitOfWork>();


            return services;
        }
        
    }
}
