using System.Collections.Generic;
using Series.Domain.Entities;
using Series.Domain.Enums;
using Series.Domain.Repositories;

namespace Series.Infra.Data.Repositories
{
    public class RepoSerie : IRepoSerie
    {
        public bool Add(Serie serie)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(Serie serie)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Serie> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Serie> GetSeriesByGenre(Genre genre)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Serie> GetSeriesByName(string serieName)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Serie serie)
        {
            throw new System.NotImplementedException();
        }
    }
}