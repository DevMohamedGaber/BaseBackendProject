﻿using Microsoft.Extensions.DependencyInjection;
using Application.Common.Behaviors;
using System.Reflection;
using FluentValidation;
using MediatR;

namespace Application
{
    public static class ServiceExtentions
    {
        public static void ConfigureApplication(this IServiceCollection services)
        {
            var assimbly = Assembly.GetExecutingAssembly();
            services.AddAutoMapper(assimbly);

            services.AddMediatR(config =>
            {
                config.RegisterServicesFromAssembly(assimbly);
            });

            services.AddValidatorsFromAssembly(assimbly);

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
        }
    }
}