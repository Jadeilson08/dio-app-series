using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Series.Domain.Enums;

namespace Series.Domain.Entities
{
    public class Serie : BasicEntity
    {
        public Serie(string title, string description, int year, string genre)
        {
            Id = Guid.NewGuid();
            Title = title;
            Description = description;
            Year = year;
            SerieGenre = ConvertToGenre(genre);
        }

        public Genre SerieGenre { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public int Year { get; private set; }

        private Genre ConvertToGenre(string genre)
        {
            if (String.IsNullOrEmpty(genre))
                throw new ArgumentException("genre cannot is null or empty");

            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

            genre = textInfo.ToTitleCase(genre.ToLower());

            Genre newGenre = Enum.Parse<Genre>(genre);

            System.Console.WriteLine(newGenre);

            return newGenre;
        }
    }
}