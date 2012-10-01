using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieGraph.Data
{
    class Actor
    {
        string Name { get; set; }
        List<Movie> Movies { get; protected set; }
    }
}
