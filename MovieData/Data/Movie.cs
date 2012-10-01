﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieGraph.Data
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
    }
}