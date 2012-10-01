using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MovieData.Data;

namespace MovieData.Data
{
    class Library
    {
        public List<Movie> Movies { get; protected set; }
        public Dictionary<string, Actor> Actors { get; protected set; }

        public Library()
        {
            Movies = new List<Movie>();
            Actors = new Dictionary<string,Actor>();
        }
    }
}
