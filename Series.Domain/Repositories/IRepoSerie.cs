using System.Collections;
using System.Collections.Generic;
using Series.Domain.Entities;
using Series.Domain.Enums;

namespace Series.Domain.Repositories
{
    public interface IRepoSerie
    {
        IEnumerable<Serie> GetAll();
        IEnumerable<Serie> GetSeriesByName(string serieName);
        IEnumerable<Serie> GetSeriesByGenre(Genre genre);
        bool Add(Serie serie);
        bool Update(Serie serie);
        bool Delete(Serie serie);
    }
}