using Microsoft.EntityFrameworkCore;
// using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Series.Infra.Data.Context;

namespace Series.Infra.IoC
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection service)
        {
            // service.AddDbContext<SeriesContext>(
            //     options => options.UseSqlite(configuration.GetConnectionString("SeriesSQLite")));

            service.AddDbContext<SeriesContext>(options =>
                options.UseInMemoryDatabase("name"));
            
            return service;
        }
    }
}