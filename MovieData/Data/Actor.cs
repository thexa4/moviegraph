using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieGraph.Data
{
    class Actor
    {
        public string Name { get; set; }
        public List<Movie> Movies { get; protected set; }
    }
}
