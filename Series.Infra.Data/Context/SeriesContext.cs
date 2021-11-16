using Microsoft.EntityFrameworkCore;
using Series.Domain.Entities;
using Series.Infra.Data.Context.Config;

namespace Series.Infra.Data.Context
{
    public class SeriesContext : DbContext
    {
        public SeriesContext(DbContextOptions<SeriesContext> options) : base(options)
        {
        }

        public DbSet<Serie> Series { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SeriesTypeConfiguration).Assembly);

            modelBuilder.Entity<Serie>().HasData(
                new Serie ("Blade", 
                    "Blade, who is part-vampire and part-mortal, becomes a vampire hunter to protect human beings. He prevents vampires from taking control over the human race."
                    , 1998){}
            );
        }
    }
}