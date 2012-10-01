using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieData.Data
{
    public class Movie
    {
        /// <summary>
        /// The IMDB id of the current movie
        /// </summary>
        public string IMDBId { get; set; }
        /// <summary>
        /// The title of the movie
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The year the movie was released
        /// </summary>
        public int Year { get; set; }
        /// <summary>
        /// The actors that play in the movie
        /// </summary>
        public List<Actor> Actors { get; protected set; }
        /// <summary>
        /// The genres of the movie
        /// </summary>
        public List<string> Genres { get; protected set; }
        /// <summary>
        /// The url to the poster of the movie
        /// </summary>
        public string Poster { get; set; }
        /// <summary>
        /// The average rating of the movie on IMDB
        /// </summary>
        public float Rating { get; set; }
        /// <summary>
        /// A plot summary of the movie
        /// </summary>
        public string Plot { get; set; }

        /// <summary>
        /// Creates a new Movie
        /// </summary>
        public Movie()
        {
            Actors = new List<Actor>();
            Genres = new List<string>();
        }
    }
}
