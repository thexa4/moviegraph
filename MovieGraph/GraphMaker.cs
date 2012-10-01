using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MovieGraph
{
    class GraphMaker
    {
        Stream output;


        public GraphMaker(Stream output)
        {
            // TODO: Complete member initialization
            this.output = output;
        }

        internal void MovieGraph(MovieData.Data.Library lib)
        {
            
        }

        internal void ActorGraph(MovieData.Data.Library lib)
        {
            throw new NotImplementedException();
        }
    }
}
