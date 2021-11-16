using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Series.Domain.Entities;

namespace Series.Infra.Data.Context.Config
{
    public class SeriesTypeConfiguration : IEntityTypeConfiguration<Serie>
    {
        public void Configure(EntityTypeBuilder<Serie> builder)
        {
            builder.Property(x => x.Title).HasMaxLength(50);
            builder.Property(x => x.Description).HasMaxLength(500);
        }
    }
}