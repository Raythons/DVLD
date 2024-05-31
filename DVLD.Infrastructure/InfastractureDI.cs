using DLVD.App.Interfaces;
using DVLD.App.Interfaces.Persistence;
using DVLD.Data;
using DVLD.Data.Repositories;
using DVLD.Infrastructure.FileStorage;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace DVLD.Infrastructure
{
    public static class InfastractureDI
    {   
        public static IServiceCollection AddInfrastructureServices (
                        this IServiceCollection  services,
                        IConfiguration config)
        {
            services.AddDbContext<DvldContext>
                (
                options => options.UseSqlServer(config.GetConnectionString("DVLDConnectionString"))
                ); 

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddSingleton<IFileStorageService, LocalFileStorageService>();
            return services;
        }
    }
}


