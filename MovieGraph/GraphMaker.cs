using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using MovieData.Data;

namespace MovieGraph
{
    class GraphMaker
    {
        Stream output;


        public GraphMaker(Stream output, Library lib)
        {
            // TODO: Complete member initialization
            this.output = output;
        }

        internal void MovieGraph()
        {
            
        }

        internal void ActorGraph()
        {
            throw new NotImplementedException();
        }
    }
}
