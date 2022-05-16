using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSU.Coins.Ioc
{
   
        public static class ServiceCollectionExtensions
        {
            public static IServiceCollection AddDatabase(this IServiceCollection services,
                IConfiguration configuration)
            {
                var connectionString = configuration.GetConnectionString("ConnectionString");
                services.AddDbContext<CoinsContext>(options => options
                    .UseSqlServer(connectionString));
                return services;
                
            }
        }
    
}
