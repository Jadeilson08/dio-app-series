using System;
using System.Collections.Generic;
using System.Linq;
using Series.Domain.Entities;
using Series.Domain.Enums;
using Series.Domain.Repositories;
using Series.Infra.Data.Context;

namespace Series.Infra.Data.Repositories
{
    public class RepoSerie : IRepoSerie
    {
        private readonly SeriesContext _context;
        public RepoSerie(SeriesContext context)
        {
            _context = context;
        }
        public bool Add(Serie serie)
        {
            _context.Add(serie);
            bool isSaved = Convert.ToBoolean(_context.SaveChanges());

            return isSaved;
        }

        public bool Delete(Serie serie)
        {
            _context.Remove(serie);
            bool isDeleted = Convert.ToBoolean(_context.SaveChanges());

            return isDeleted;
        }

        public IEnumerable<Serie> GetAll()
        {
            return _context.Series.ToList();
        }

        public IEnumerable<Serie> GetSeriesByGenre(Genre genre)
        {
            return _context.Series.Where(x => x.SerieGenre.ToString().Contains(genre.ToString())).ToList();
        }

        public IEnumerable<Serie> GetSeriesByName(string serieName)
        {
            return _context.Series.Where(x => x.Title.Contains(serieName)).ToList();
        }

        public bool Update(Serie serie)
        {
            _context.Update(serie);
            bool isUpdated = Convert.ToBoolean(_context.SaveChanges());

            return isUpdated;
        }
    }
}