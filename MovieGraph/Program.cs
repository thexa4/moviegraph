﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using MovieData.Data;


namespace MovieGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            Stream output = new FileStream("./filename", FileMode.OpenOrCreate);
            Library lib = new Library();
            var g = new GraphMaker(output, lib);
            if (args.Length > 0)
            {
                if (args[0].Equals("Movies"))
                    g.MovieGraph();
                else if (args[0].Equals("Actors"))
                    g.ActorGraph();
            }
        }
    }
}
