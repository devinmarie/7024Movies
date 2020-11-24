using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Serialization;

namespace _7024Movies.Pages
{
    public class SoccerMoviesModel : PageModel
    {
        public void OnGet()
        {
            using (var webClient = new WebClient())
            {
                string MovieReviews = webClient.DownloadString("https://api.themoviedb.org/3/search/movie?api_key=a852a3b3771672da86800503084b853b&language=en-US&sort_by=popularity.desc&query=Soccer&page=1&include_adult=false");
                var results = SearchResults.FromJson(MovieReviews);
                var results2 = results.Results;
                ViewData["SoccerResults"] = results2;

                DateTime dateTime = DateTime.UtcNow.Date;
                string currentdate = dateTime.ToString("yyyy-MM-dd");
                //string soccerstring = String.Format("http://api.sportsdata.io/v3/soccer/scores/json/GamesByDate/{0}?key=bc49021bad1943008414c5a75e665961", currentdate);
                ViewData["currentdate"] = currentdate;
                //SoccerGame.SoccerGames[] Game = SoccerGame.SoccerGames.FromJson(soccerstring);
                //ViewData["SoccerGames"] = Game;
            }

        }
    }
}
