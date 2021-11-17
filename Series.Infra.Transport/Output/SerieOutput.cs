using System;
using System.Collections.Generic;

namespace Series.Infra.Transport.Output
{
    public class SerieOutput
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Genres { get; set; }
    }
}