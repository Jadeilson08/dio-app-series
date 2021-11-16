using System.Collections.Generic;
using Series.Domain.Entities;
using Series.Domain.Repositories;

namespace Series.Application.Service.Series
{
    public class SrSerie : ISrSerie
    {
        private readonly IRepoSerie _repoSerie;

        public SrSerie(IRepoSerie repoSerie)
        {
            _repoSerie = repoSerie;
        }

        public IEnumerable<Serie> GetAll()
        {
            return _repoSerie.GetAll();
        }
    }
}