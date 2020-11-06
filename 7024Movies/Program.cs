using IMDbApiLib;
using IMDbApiLib.Models;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;


namespace _7024Movies
{
    public class Program
    {
        static readonly HttpClient client = new HttpClient();

        static async System.Threading.Tasks.Task Main(string[] args) 
        {
            CreateHostBuilder(args).Build().Run();
            Console.WriteLine("Movie to Search: ");
            string movieToSearch = Console.ReadLine();
            movieToSearch.Replace(" ", "%20");
            string apiKey = System.IO.File.ReadAllText("TmdbApiKey.txt");
            //https://api.themoviedb.org/3/movie/550?api_key=a852a3b3771672da86800503084b853b
            //https://api.themoviedb.org/3/search/movie?api_key=a852a3b3771672da86800503084b853b&language=en-US&query=inception&page=1&include_adult=false

            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                string uri = String.Format("https://api.themoviedb.org/3/search/movie?api_key={0}&language=en-US&query={1}&page=1&include_adult=false", apiKey, movieToSearch);
                HttpResponseMessage response = await client.GetAsync(uri);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);
                SearchResults testSearchResults = SearchResults.FromJson(responseBody);

                for (int i = 0; i < testSearchResults.Results.Length; i++)
                {
                    Console.WriteLine(String.Format("Movie: {0}, Id: {1}", testSearchResults.Results[i].OriginalTitle, testSearchResults.Results[i].Id));
                }

                while (testSearchResults.Page < testSearchResults.TotalPages)
                {
                    uri = String.Format("https://api.themoviedb.org/3/search/movie?api_key={0}&language=en-US&query={1}&page={2}&include_adult=false", apiKey, movieToSearch, testSearchResults.Page + 1);
                    response = await client.GetAsync(uri);
                    response.EnsureSuccessStatusCode();
                    responseBody = await response.Content.ReadAsStringAsync();
                    // Above three lines can be replaced with new helper method below
                    // string responseBody = await client.GetStringAsync(uri);
                    testSearchResults = SearchResults.FromJson(responseBody);
                    for (int i = 0; i < testSearchResults.Results.Length; i++)
                    {
                        Console.WriteLine(String.Format("Movie: {0}, Id: {1}", testSearchResults.Results[i].OriginalTitle, testSearchResults.Results[i].Id));
                    }
                }
                Console.WriteLine("Movie Id to Search: ");
                string movieId = Console.ReadLine();

                // Display relevant information about results somehow
                //User clicks movie, get the Id from the movie the user clicked on
                uri = String.Format("https://api.themoviedb.org/3/movie/{0}?api_key={1}&language=en-US", movieId.ToString(), apiKey);
                response = await client.GetAsync(uri);
                response.EnsureSuccessStatusCode();
                responseBody = await response.Content.ReadAsStringAsync();

                Movie testMovie = Movie.FromJson(responseBody);
                Console.WriteLine("IMDB Title: " + testMovie.ImdbId);

                var apiLib = new ApiLib("k_vxcfqztc");
                var testIMDB = await apiLib.TitleAsync(testMovie.ImdbId, Language.en, "FullActor,FullCast,Posters,Images,Trailer,Ratings,Wikipedia");

                Console.WriteLine("Full Title: " + testIMDB.FullTitle);
                Console.WriteLine("Director: " + testIMDB.Directors);
                Console.WriteLine("IMDB Rating: " + testIMDB.IMDbRating);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }

}
