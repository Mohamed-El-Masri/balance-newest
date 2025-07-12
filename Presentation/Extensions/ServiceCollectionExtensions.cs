using Microsoft.Extensions.DependencyInjection;

namespace Presentation.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPresentationServices(this IServiceCollection services)
        {
            // سيتم إضافة الخدمات المخصصة لاحقاً
            return services;
        }
    }
} 