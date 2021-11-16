using System;
using System.Collections.Generic;
using System.Linq;
using Series.Domain.Enums;

namespace Series.Domain.Entities
{
    public class Serie : BasicEntity
    {
        public Serie(string title, string description, int year)
        {
            Title = title;
            Description = description;
            Year = year;
            Id = Guid.NewGuid();
            _genres = new List<Genre>();
        }

        public IReadOnlyCollection<Genre> Genres { get { return _genres.ToArray(); } }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public int Year { get; private set; }

        private IList<Genre> _genres;

        public void AddGenre(Genre genre)
        {
            _genres.Add(genre);
        }
    }
}