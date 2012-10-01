using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MovieData.Data;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;

namespace MovieData.Service
{
    public class Imdb
    {
        const string Endpoint = "http://www.omdbapi.com/";
        Library Library { get; set; }

        public Imdb(Library library)
        {
            Library = library;
        }

        /// <summary>
        /// Searches omdbapi for movie by title and year and adds it to the library
        /// </summary>
        /// <param name="title">The movie title</param>
        /// <param name="year">The year</param>
        public void FindMovie(string title, int year)
        {
            ParseMovie(new WebClient().DownloadString(Endpoint + "?t=" + title + "&y=" + year.ToString()));
        }

        /// <summary>
        /// Searches omdbapi for movie by title and adds it to the library
        /// </summary>
        /// <param name="title">The movie title</param>
        public void FindMovie(string title)
        {
            ParseMovie(new WebClient().DownloadString(Endpoint + "?t=" + title));
        }

        /// <summary>
        /// Parses omdbapi json and adds it to the Library
        /// </summary>
        /// <param name="json">The movie JSON</param>
        void ParseMovie(string json)
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

            string[] actors = ((string)j["Actors"]).Split(", ".ToCharArray());
            foreach(var actor in actors)
            {
                if (!Library.Actors.ContainsKey(actor))
                    Library.Actors.Add(actor, new Actor() { Name = actor });

                var a = Library.Actors[actor];
                m.Actors.Add(a);
                a.Movies.Add(m);
            }

            Library.Movies.Add(m);
        }
    }
}