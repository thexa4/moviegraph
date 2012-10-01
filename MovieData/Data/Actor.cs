using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieData.Data
{
    class Actor
    {
        public string Name { get; set; }
        public List<Movie> Movies { get; protected set; }

        public Actor()
        {
            Movies = new List<Movie>();
        }
    }
}
