﻿using Application.ResourceServant;
using Application.Services;
using Core.ResourceServant;
using Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class ApplicationModule
    {
        public static IServiceCollection AddApplicationDependencies(this IServiceCollection services)
        {
            services.AddScoped<IHotelService, HotelService>();
            services.AddScoped<IReviewService, ReviewService>();
            services.AddScoped<IPictureService, PictureService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRoomService, RoomService>();

            services.AddScoped<IDisplayModelResourceServant, DisplayModelResourceServant>();

            return services;
        }
    }
}