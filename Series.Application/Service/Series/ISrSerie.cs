using System.Collections.Generic;
using Series.Domain.Entities;
using Series.Infra.Transport.Input;

namespace Series.Application.Service.Series
{
    public interface ISrSerie
    {
        IEnumerable<Serie> GetAll();

        bool Create(SerieInput serie);
    }
}