using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieGraph.Data
{
    class Movie
    {
        string IMDBId { get; set; }
        string Name { get; set; }
        int Year { get; set; }
        List<Actor> Actors { get; protected set; }
        List<string> Genres { get; protected set; }
        string Poster { get; set; }
        float Rating { get; set; }
        string Plot { get; set; }
    }
}
