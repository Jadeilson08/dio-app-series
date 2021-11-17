using System.Linq;
using System.Collections.Generic;
using AutoMapper;
using Series.Domain.Entities;
using Series.Domain.Repositories;
using Series.Infra.Transport.Input;
using Series.Infra.Transport.Output;

namespace Series.Application.Service.Series
{
    public class SrSerie : ISrSerie
    {
        private readonly IRepoSerie _repoSerie;

        public SrSerie(IRepoSerie repoSerie, IMapper mapper)
        {
            _repoSerie = repoSerie;
        }

        public bool Create(SerieInput serieInput)
        {
            Serie serie = new Serie(serieInput.Title, serieInput.Description, serieInput.Year, serieInput.Genre);

            return _repoSerie.Add(serie);
        }

        public IEnumerable<SerieOutput> GetAll()
        {
            var serieOutputs = _repoSerie.GetAll()
                .Select(x => new SerieOutput 
                {
                    Id = x.Id,
                    Title = x.Title,
                    Description = x.Description,
                    Genres = x.SerieGenre.ToString()
                }
                );
            return serieOutputs;
        }

        public IEnumerable<Serie> GetGeneros()
        {
            return _repoSerie.GetAll();
        }
    }
}