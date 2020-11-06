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
    public class TestingModel : PageModel
    {
        public void OnGet()
        {
            using (var webClient = new WebClient())
            {
                string JsonString = webClient.DownloadString("https://api.themoviedb.org/3/search/movie?api_key=a852a3b3771672da86800503084b853b&language=en-US&query=starwars&page=1&include_adult=false");
                var results = SearchResults.FromJson(JsonString);
                var results2 = results.Results;
                ViewData["MovieResults"] = results2;
            }
        }
    }
}
