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
        StreamWriter writer;

        public GraphMaker(Stream output, Library lib)
        {
            this.lib = lib;
            this.output = output;
            writer = new StreamWriter(output);

        }

        internal void MovieGraph()
        {
            writer.WriteLine("graph movies {");

            for (int i = 0; i < lib.Actors.Count; i++)
            {
                Actor act = lib.Actors.ElementAt(0).Value;
                foreach (Movie mov in act.Movies)
                    foreach (Movie mov2 in act.Movies)
                        if (mov.Name.CompareTo(mov2.Name) < 0)
                            writer.WriteLine(mov.Name + " -- " + mov2.Name + " [label=" + act.Name + "];");
            }

            writer.WriteLine("}");

        }

        internal void ActorGraph()
        {
            writer.WriteLine("graph actors {");

            foreach (Movie mov in lib.Movies)
                foreach (Actor act in mov.Actors)
                    foreach (Actor act2 in mov.Actors)
                        if (act.Name.CompareTo(act2.Name) < 0)
                           writer.WriteLine(act.Name + " -- " + act2.Name + " [label=" + mov.Name + "];");

            writer.WriteLine("}");
        }
    }
}
