﻿using Core.Repositories;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class InfrastructureModule
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
        {
            services.AddScoped<IRoomPriceRepository, RoomPriceRepository>();
            services.AddScoped<IRoomRepository, RoomRepository>();
            services.AddScoped<IHotelRepository, HotelRepository>();
            services.AddScoped<IOccupationRepository, OccupationRepository>();
            services.AddScoped<IReviewRepository, ReviewRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}