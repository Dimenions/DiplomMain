using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSU.Coins.BLL.Interface;
using SSU.Coins.BLL;

namespace SSU.Coins.Ioc
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection Configuration(this IServiceCollection services)
        {
            return services.AddTransient<ICoinLogic, CoinLogic>()
                .AddTransient<ICountryLogic, CountryLogic>()
                .AddTransient<IMaterialLogic, MaterialLogic>()
                //.AddTransient<IUserLogic, UserLogic>()
                //.AddTransient<IRoleProviderLogic, RoleProviderLogic>()
                .AddTransient<IRoleWebSiteLogic, RoleWebSiteLogic>();
        }

    }
}
