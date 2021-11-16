using System.Collections.Generic;
using Series.Domain.Entities;

namespace Series.Application.Service.Series
{
    public interface ISrSerie
    {
        IEnumerable<Serie> GetAll();
    }
}