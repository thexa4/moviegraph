using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieData.Data
{
    class Movie
    {
        public string IMDBId { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public List<Actor> Actors { get; protected set; }
        public List<string> Genres { get; protected set; }
        public string Poster { get; set; }
        public float Rating { get; set; }
        public string Plot { get; set; }

        public Movie()
        {
            Actors = new List<Actor>();
            Genres = new List<string>();
        }
    }
}
