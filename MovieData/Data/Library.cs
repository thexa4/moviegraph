using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MovieData.Data;

namespace MovieData.Data
{
    /// <summary>
    /// Stores data about the movies you viewed
    /// </summary>
    public class Library
    {
        /// <summary>
        /// The movies you added
        /// </summary>
        public List<Movie> Movies { get; protected set; }
        /// <summary>
        /// The unique actors that play in your movies
        /// </summary>
        public Dictionary<string, Actor> Actors { get; protected set; }

        /// <summary>
        /// Creates a new movie library
        /// </summary>
        public Library()
        {
            Movies = new List<Movie>();
            Actors = new Dictionary<string,Actor>();
        }
    }
}
