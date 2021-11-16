using Microsoft.EntityFrameworkCore;
using Series.Domain.Entities;

namespace Series.Infra.Data.Context
{
    public class SeriesContext : DbContext
    {
        public SeriesContext(DbContextOptions<SeriesContext> options) : base(options)
        {
        }

        public DbSet<Serie> Series { get; set; }
    }
}