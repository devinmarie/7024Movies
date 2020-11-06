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

namespace _7024Movies.Pages
{
    public class DiscoverThrillerModel : PageModel
    {
        public void OnGet()
        {
            using (var webClient = new WebClient())
            {
                string JsonString = webClient.DownloadString("https://api.themoviedb.org/3/discover/movie?api_key=a852a3b3771672da86800503084b853b&language=en-US&sort_by=popularity.desc&include_adult=false&include_video=false&page=1&vote_count.gte=5000&with_genres=53&with_original_language=en");
                var discoverthriller = DiscoverM.DiscoverMovie.FromJson(JsonString);
                var thrillermovies = discoverthriller.Results;
                ViewData["Thrillers"] = thrillermovies;

                List<MovieId.MovieIds> thrillerid = new List<MovieId.MovieIds>();
                string uri = "";
                foreach (DiscoverM.Result movie in thrillermovies)
                {

                    string movieid = movie.Id.ToString();
                    uri = String.Format("https://api.themoviedb.org/3/movie/{0}/external_ids?api_key=a852a3b3771672da86800503084b853b", movieid);
                    string JsonString2 = webClient.DownloadString(uri);
                    var movielookup = MovieId.MovieIds.FromJson(JsonString2);
                    thrillerid.Add(movielookup);
                }
                ViewData["ThrillerLkp"] = thrillerid;

                //Dictionary was created to practice class excercise
                /*IDictionary<long, DiscoverM.Result> thrillerdic = new Dictionary<long, DiscoverM.Result>();
                foreach (DiscoverM.Result movie in thrillermovies)
                {
                    thrillerdic.Add(movie.Id, movie);
                }
                */

                //List was created in case this was needed to filter anything
                /*List<long> ids = new List<long>();
                foreach (DiscoverM.Result movie in thrillermovies)
                {
                    ids.Add(movie.Id);
                }
                ViewData["Ids"] = ids;
                */

            }
        }
    }
}
