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
    /// <summary>
    /// Queries omdbapi for movies
    /// </summary>
    public class Imdb
    {
        /// <summary>
        /// The api endpoint
        /// </summary>
        const string Endpoint = "http://www.omdbapi.com/";
        /// <summary>
        /// The library to write movies to
        /// </summary>
        Library Library { get; set; }

        /// <summary>
        /// Creates a new imdb service
        /// </summary>
        /// <param name="library">The library to write to</param>
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
        public void ParseMovie(string json)
        {
            JObject j = JObject.Parse(json);

            if (!bool.Parse((string)j["Response"]))
                throw new Exception((string)j["Error"]);

            Movie m = new Movie()
            {
                Name = (string)j["Title"],
                Year = int.Parse((string)j["Year"]),
                Poster = (string)j["Poster"],
                Rating = float.Parse((string)j["imdbRating"]),
                IMDBId = (string)j["imdbID"],
                Plot = (string)j["Plot"],
            };

            string[] actors = ((string)j["Actors"]).Split(",".ToCharArray());
            foreach(var actor in actors)
            {
                var t = actor.Trim();

                if (t.Length == 0)
                    continue;

                if (!Library.Actors.ContainsKey(t))
                    Library.Actors.Add(t, new Actor() { Name = t });

                var a = Library.Actors[t];
                m.Actors.Add(a);
                a.Movies.Add(m);
            }

            Library.Movies.Add(m);
        }
    }
}