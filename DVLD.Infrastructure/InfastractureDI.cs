using DVLD.App.Interfaces.Persistence;
using DVLD.Data;
using DVLD.Data.Repositories;
using DVLD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return services;
        }
    }
}


