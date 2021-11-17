using System.Collections.Generic;
using Series.Domain.Entities;
using Series.Infra.Transport.Input;
using Series.Infra.Transport.Output;

namespace Series.Application.Service.Series
{
    public interface ISrSerie
    {
        IEnumerable<SerieOutput> GetAll();
        IEnumerable<Serie> GetGeneros();

        bool Create(SerieInput serie);
    }
}