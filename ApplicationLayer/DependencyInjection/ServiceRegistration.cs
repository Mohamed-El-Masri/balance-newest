using Microsoft.Extensions.DependencyInjection;
using Application.Interfaces;
using Application.Services;
using FluentValidation;
using FluentValidation.AspNetCore;
using Application.Validation;

namespace Application.DependencyInjection
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            // Register Application Services
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<IUnitService, UnitService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ITaskService, TaskService>();
            services.AddScoped<INotificationService, NotificationService>();
            services.AddScoped<IContentComponentService, ContentComponentService>();
            
            // Register FluentValidation
            services.AddValidatorsFromAssemblyContaining<ProjectCreateDtoValidator>();
            
            return services;
        }
    }
}
