using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using DiscoverM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Serialization;
using IMDbApiLib;
using IMDbApiLib.Models;
using MovieId;

namespace _7024Movies.Pages
{
    public class DiscoverThrillerModel : PageModel
    {
        public void OnGet()
        {
            using (var webClient = new WebClient())
            {
                string JsonString = webClient.DownloadString("https://api.themoviedb.org/3/discover/movie?api_key=a852a3b3771672da86800503084b853b&language=en-US&sort_by=popularity.desc&include_adult=false&include_video=false&page=1&vote_count.gte=5000&with_genres=53&with_original_language=en");
                JSchema schema = JSchema.Parse(System.IO.File.ReadAllText("DiscoverMovieSchema.json"));
                JObject jsonObject = JObject.Parse(JsonString);
                if (jsonObject.IsValid(schema))
                {
                    var DiscoverThriller = DiscoverM.DiscoverMovie.FromJson(JsonString);
                    var ThrillerMovies = DiscoverThriller.Results;
                    ViewData["Thrillers"] = ThrillerMovies;


                    List<MovieId.MovieIds> thrillerid = new List<MovieId.MovieIds>();
                    string uri = "";
                    foreach (DiscoverM.Result movie in ThrillerMovies)
                    {

                        string MovieId = movie.Id.ToString();
                        uri = String.Format("https://api.themoviedb.org/3/movie/{0}/external_ids?api_key=a852a3b3771672da86800503084b853b", MovieId);
                        string JsonString2 = webClient.DownloadString(uri);
                        JSchema lkpschema = JSchema.Parse(System.IO.File.ReadAllText("MovieIdSchema.json"));
                        JObject jsonlkpschema = JObject.Parse(JsonString2);
                        if (jsonlkpschema.IsValid(lkpschema))
                        {
                            var MovieLookup = global::MovieId.MovieIds.FromJson(JsonString2);
                            thrillerid.Add(MovieLookup);
                            ViewData["ThrillerLkp"] = thrillerid;
                        }
                    }

                    List<IMDB.MovieImdb> thrillerimdb = new List<IMDB.MovieImdb>();
                    foreach (MovieIds movie in thrillerid)
                    {
                        //k_3re1w44s
                        //k_vxcfqztc
                        //k_1gkshhzw
                        string movieid = movie.ImdbId.ToString();
                        uri = String.Format("https://imdb-api.com/en/API/Title/k_1gkshhzw/{0}", movieid);
                        string ImdbString = webClient.DownloadString(uri);
                        JSchema idmbschema = JSchema.Parse(System.IO.File.ReadAllText("MovieIMDB.json"));
                        JObject jsonimdbschema = JObject.Parse(ImdbString);
                        if (jsonimdbschema.IsValid(idmbschema))
                        {
                            var ImdbRating = IMDB.MovieImdb.FromJson(ImdbString);
                            thrillerimdb.Add(ImdbRating);
                            ViewData["ThrillerIMDB"] = thrillerimdb;
                        }
                    }
                }

            }
        }
    }
}
