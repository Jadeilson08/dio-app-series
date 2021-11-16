using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Series.Application.Service.Series;
using Series.Domain.Repositories;
using Series.Infra.Data.Context;
using Series.Infra.Data.Repositories;

namespace Series.Infra.IoC
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<SeriesContext>(options =>
                options.UseInMemoryDatabase("SeriesDb"));
            
            return services;
        }
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRepoSerie, RepoSerie>();
            
            return services;
        }
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ISrSerie, SrSerie>();
            
            return services;
        }
    }
}