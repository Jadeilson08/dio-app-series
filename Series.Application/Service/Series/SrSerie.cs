using System.Collections.Generic;
using Series.Domain.Entities;
using Series.Domain.Repositories;
using Series.Infra.Transport.Input;

namespace Series.Application.Service.Series
{
    public class SrSerie : ISrSerie
    {
        private readonly IRepoSerie _repoSerie;

        public SrSerie(IRepoSerie repoSerie)
        {
            _repoSerie = repoSerie;
        }

        public bool Create(SerieInput serieInput)
        {
            Serie serie = new Serie(serieInput.Title, serieInput.Description, serieInput.Year);

            return _repoSerie.Add(serie);
        }

        public IEnumerable<Serie> GetAll()
        {
            return _repoSerie.GetAll();
        }
    }
}