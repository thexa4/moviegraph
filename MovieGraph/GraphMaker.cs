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
        Library lib;

        public GraphMaker(Stream output, Library lib)
        {
            this.lib = lib;
            this.output = output;
        }

        internal void MovieGraph()
        {
            String str = "graph movies {\n";

            for (int i = 0; i < lib.Actors.Count; i++)
            {
                Actor act = lib.Actors.ElementAt(0).Value;
                foreach (Movie mov in act.Movies)
                    foreach (Movie mov2 in act.Movies)
                        if (mov.Name.CompareTo(mov2.Name) < 0)
                            str += mov.Name + " -- " + mov2.Name + " [label=" + act.Name + "];\n";
            }

            str += "}";

        }

        internal void ActorGraph()
        {
            String str = "graph actors {\n";

            foreach (Movie mov in lib.Movies)
                foreach (Actor act in mov.Actors)
                    foreach (Actor act2 in mov.Actors)
                        if (act.Name.CompareTo(act2.Name) < 0)
                            str += act.Name + " -- " + act2.Name + " [label=" + mov.Name + "];\n";

            str += "}";
        }
    }
}
