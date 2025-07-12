using Microsoft.Extensions.DependencyInjection;
using Infrastructure.Data;
using Infrastructure.Data.Repositories;
using Infrastructure.Integrations;
using Infrastructure.Mapping;
using Microsoft.EntityFrameworkCore;
using Application.Interfaces;

namespace Infrastructure.DependencyInjection
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IProjectRepository, ProjectRepository>();
            services.AddScoped<IUnitRepository, UnitRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ITaskRepository, TaskRepository>();
            services.AddScoped<INotificationRepository, NotificationRepository>();
            services.AddScoped<IContentComponentRepository, ContentComponentRepository>();
            services.AddScoped<ICloudinaryService, CloudinaryService>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<Infrastructure.Integrations.INotificationService, Infrastructure.Integrations.NotificationService>();
            services.AddScoped<ILocalizationService, LocalizationService>();
            services.AddAutoMapper(typeof(AutoMapperProfiles));
            // ... add other services as needed
            return services;
        }
    }
} 