using Microsoft.AspNetCore.Builder;
using MyCustomIMDb.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace MyCustomIMDb.Infrastructure
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder PrepareDatabase(this IApplicationBuilder app)
        {
            var scopedServices = app.ApplicationServices.CreateScope();

            var data = scopedServices.ServiceProvider.GetService<CustomIMDbDbContext>();

            data.Database.Migrate();

            return app;
        }
    }
} 