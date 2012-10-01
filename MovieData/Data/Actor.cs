using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieData.Data
{
    /// <summary>
    /// Stores information about Actors
    /// </summary>
    public class Actor
    {
        /// <summary>
        /// The name of the actor
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The added movies the actor played in
        /// </summary>
        public List<Movie> Movies { get; protected set; }

        /// <summary>
        /// Creates a new actor
        /// </summary>
        public Actor()
        {
            Movies = new List<Movie>();
        }
    }
}
