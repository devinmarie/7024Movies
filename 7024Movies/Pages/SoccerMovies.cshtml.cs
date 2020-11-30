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
                string SoccerReviews = webClient.DownloadString("https://api.themoviedb.org/3/search/movie?api_key=a852a3b3771672da86800503084b853b&language=en-US&sort_by=popularity.desc&query=Soccer&page=1&include_adult=false");
                var SoccerJson = SearchResults.FromJson(SoccerReviews);
                var SoccerResults = SoccerJson.Results;
                ViewData["SoccerResults"] = SoccerResults;

                string BeckhamReviews = webClient.DownloadString("https://api.themoviedb.org/3/search/movie?api_key=a852a3b3771672da86800503084b853b&language=en-US&sort_by=popularity.desc&query=Beckham&page=1&include_adult=false");
                var BeckhamJson = SearchResults.FromJson(BeckhamReviews);
                var BeckhamResults = BeckhamJson.Results;
                ViewData["BeckhamResults"] = BeckhamResults;

                string PlayerJson = webClient.DownloadString("https://api.sportsdata.io/v3/soccer/scores/json/MembershipsByCompetition/EPL?key=bc49021bad1943008414c5a75e665961");
                QuickType.PlayerInfo[] PlayerInfo = QuickType.PlayerInfo.FromJson(PlayerJson);
                ViewData["PlayerInfo"] = PlayerInfo;

            }
        }
    }
}
