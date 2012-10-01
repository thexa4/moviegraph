using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MovieData.Data;
using Newtonsoft.Json.Linq;
using System.IO;

namespace MovieData.Service
{
    class Imdb
    {
        const string Endpoint = "";

        static Movie FindMovie(string title, int year)
        {
            return null;
        }

        static Movie ParseMovie(string json)
        {
            JObject j = JObject.Parse(json);

            if (!bool.Parse((string)j["Response"]))
                throw new Exception((string)j["Error"]);

            Movie m = new Movie()
            {
                Name = (string)j["Title"],
                Year = int.Parse((string)j["Year"]),
                Poster = (string)j["Poster"],
                Rating = float.Parse((string)j["Rating"]),
                IMDBId = (string)j["imdbID"],
                Plot = (string)j["Plot"],
            };

            string[] actors = ((string)j["Actors"]).Split(',');
            foreach(var actor in actors)
            {

            }

            return m;
        }
    }
}