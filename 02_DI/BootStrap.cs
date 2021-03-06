﻿using Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Repository;
using Services;

namespace _02_DI
{
    public class Bootstrap
    {

        public static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });

        public static void Configure(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BaseContext>(options =>
            {
                options.UseMySql(configuration.GetConnectionString("DefaultConnection"));
                options.UseLoggerFactory(MyLoggerFactory);
                options.EnableSensitiveDataLogging();
                options.UseLazyLoadingProxies();
            });
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IImageService, ImageService>();
        }
    }
}



