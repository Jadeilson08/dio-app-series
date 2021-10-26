using Series.Domain.Enums;

namespace Series.Domain.Entities
{
    public class Serie : BasicEntity
    {
        public Genres Genre { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public int Year { get; private set; }
    }
}