# IS7024 Movie Application

## Introduction

Streaming sites have really helped users gain access to an endless number of movies, either included in their subsriptions or for a few dollars a rental. Users are able to search specific movies, get movie suggestions based on past history, or see what is trending for other users of that service. However, the unlimited options also can cause viewers to cycle through dozens of trailers, never committing to a movie due to a "grass is always greener" mentality. What if the next film is even better? I'll add this to my list to watch later as I am unsure if I want to watch this one now. What about a thriller? What about a comedy? What is trending today?

Two hours later...and still unsure what to watch!
favflick was created as a way to filter the top of the line options per genre to create a short list of guarenteed worthy films to watch when you have had enough of endless movie scrolling. Our site is built by the public and favflick contributors who choose to put their rating into the mix as well!

Users are currently able to do the following:

•	Input a movie name and get back the 20 best matched movie titles, release date, popularity and a brief overview of the movie. 

•	View the top 20 trending thriller and comedy movies. 

•	Submit a review for thriller, comedy and other movies.

•	View other users' reviews for thrillers, comedies and other movies. 


## Requirements
As a user, I want to see an aggregated list of the currently trending thriller and comedy movies to cut down on the time to find the next movie I want to watch. 

The user clicks on the dropdown arrow of either category and click on the "Trending" tab to view a curated list of the top 20 results. 

Finally, the user can sort by Movie Title, Release Year, Content Rating, TMDb Rating and IMDb Rating.

As a user, I want to view the comments of other favflick users to get better insight on a movie. 

The user clicks on "favflick" Reviews tab under Comedy or Thriller Movies to see a list of currently posted user reviews. The user can also click on "Other Movie Review" to view reviews for all other genres. 

Finally, the user can leave their own movie review for each previously mentioned category. 

As a user, I want to be able to quickly search the ratings of a movie and a brief overview so that I can decide if I want to see it or not.

Once the user has decided what movie they want to search for, they will see results of the 20 best matched movies based on the search input. 

Finally, the user will be able to sort the columns. 

## Data Sources

![Movie Database Image](https://www.themoviedb.org/assets/2/v4/logos/v2/blue_long_2-9665a76b1ae401a510ec1e0ca40ddcb3b0cfe45f1d51b77a308fea0845885648.svg)
The first data source we will be using is [The Movie Database - TMDb](https://www.themoviedb.org/documentation/api?language=en-US)

TMDb is a community built movie and TV database. Every piece of data has been added by the community dating back to 2008. TMDb's strong international focus and breadth of data is largely unmatched and the API contains over 600k movies and 100k tv shows.

### Example JSON snippet - Movie
```JSON
test({"adult":false,"backdrop_path":"/rr7E0NoGKxvbkb89eR1GwfoYjpA.jpg","belongs_to_collection":null,"budget":63000000,"genres":[{"id":18,"name":"Drama"}],"homepage":"http://www.foxmovies.com/movies/fight-club","id":550,"imdb_id":"tt0137523","original_language":"en","original_title":"Fight Club","overview":"A ticking-time-bomb insomniac and a slippery soap salesman channel primal male aggression into a shocking new form of therapy. Their concept catches on, with underground \"fight clubs\" forming in every town, until an eccentric gets in the way and ignites an out-of-control spiral toward oblivion.","popularity":35.937,"poster_path":"/plzV6fap5bGqMaIpOrihmhtd7lW.jpg","production_companies":[{"id":508,"logo_path":"/7PzJdsLGlR7oW4J0J5Xcd0pHGRg.png","name":"Regency Enterprises","origin_country":"US"},{"id":711,"logo_path":"/tEiIH5QesdheJmDAqQwvtN60727.png","name":"Fox 2000 Pictures","origin_country":"US"},{"id":20555,"logo_path":"/hD8yEGUBlHOcfHYbujp71vD8gZp.png","name":"Taurus Film","origin_country":"DE"},{"id":54051,"logo_path":null,"name":"Atman Entertainment","origin_country":""},{"id":54052,"logo_path":null,"name":"Knickerbocker Films","origin_country":"US"},{"id":25,"logo_path":"/qZCc1lty5FzX30aOCVRBLzaVmcp.png","name":"20th Century Fox","origin_country":"US"},{"id":4700,"logo_path":"/A32wmjrs9Psf4zw0uaixF0GXfxq.png","name":"The Linson Company","origin_country":""}],"production_countries":[{"iso_3166_1":"DE","name":"Germany"},{"iso_3166_1":"US","name":"United States of America"}],"release_date":"1999-10-15","revenue":100853753,"runtime":139,"spoken_languages":[{"iso_639_1":"en","name":"English"}],"status":"Released","tagline":"Mischief. Mayhem. Soap.","title":"Fight Club","video":false,"vote_average":8.4,"vote_count":20257})
```
`test({"adult":false,"backdrop_path":"/rr7E0NoGKxvbkb89eR1GwfoYjpA.jpg","belongs_to_collection":null,"budget":63000000,"genres":[{"id":18,"name":"Drama"}],"homepage":"http://www.foxmovies.com/movies/fight-club","id":550,"imdb_id":"tt0137523","original_language":"en","original_title":"Fight Club","overview":"A ticking-time-bomb insomniac and a slippery soap salesman channel primal male aggression into a shocking new form of therapy. Their concept catches on, with underground \"fight clubs\" forming in every town, until an eccentric gets in the way and ignites an out-of-control spiral toward oblivion.","popularity":35.937,"poster_path":"/plzV6fap5bGqMaIpOrihmhtd7lW.jpg","production_companies":[{"id":508,"logo_path":"/7PzJdsLGlR7oW4J0J5Xcd0pHGRg.png","name":"Regency Enterprises","origin_country":"US"},{"id":711,"logo_path":"/tEiIH5QesdheJmDAqQwvtN60727.png","name":"Fox 2000 Pictures","origin_country":"US"},{"id":20555,"logo_path":"/hD8yEGUBlHOcfHYbujp71vD8gZp.png","name":"Taurus Film","origin_country":"DE"},{"id":54051,"logo_path":null,"name":"Atman Entertainment","origin_country":""},{"id":54052,"logo_path":null,"name":"Knickerbocker Films","origin_country":"US"},{"id":25,"logo_path":"/qZCc1lty5FzX30aOCVRBLzaVmcp.png","name":"20th Century Fox","origin_country":"US"},{"id":4700,"logo_path":"/A32wmjrs9Psf4zw0uaixF0GXfxq.png","name":"The Linson Company","origin_country":""}],"production_countries":[{"iso_3166_1":"DE","name":"Germany"},{"iso_3166_1":"US","name":"United States of America"}],"release_date":"1999-10-15","revenue":100853753,"runtime":139,"spoken_languages":[{"iso_639_1":"en","name":"English"}],"status":"Released","tagline":"Mischief. Mayhem. Soap.","title":"Fight Club","video":false,"vote_average":8.4,"vote_count":20257})`

### Main Models
The three main models we plan to pull into our application from TMDb are:
* [Movie](https://developers.themoviedb.org/3/movies/get-movie-details)
* [People](https://developers.themoviedb.org/3/people/get-person-details)
* [Trending](https://developers.themoviedb.org/3/trending/get-trending)
>The team may choose to pull additional data as they see fit.


![IMDb Image](https://d29fhpw069ctt2.cloudfront.net/icon/image/38673/preview.svg)
Our second data souce will be [IMDb](https://developer.imdb.com/).

IMDb is one of the world leaders in entertainment content and information as they have over 6 million music, movie and TV titles, and over 10 million celebrities. IMDb gives us access to hundreds of millions of entertainment data points.  

### Example of Model Information
[IMDb API Usage Example and Documentation](https://developer.imdb.com/documentation/developer.imdb.pdf)
On page 5 of the developer documentation IMDb describes their file format as, "IMDbʼs data set is provided in JSON Lines file format. The files are UTF-8 encoded text files, where each line in the file is a valid JSON string. Each JSON document, one per line, relates to a single entity,
uniquely identified by an IMDb ID. We also provide a JSON schema that documents the format that is
used for each JSON document within the file."

### Example JSON Schema
public partial class MovieImdb
    {
        
        [JsonProperty("id")]
        public object Id { get; set; }

        [JsonProperty("title")]
        public object Title { get; set; }

        [JsonProperty("originalTitle")]
        public object OriginalTitle { get; set; }

        [JsonProperty("fullTitle")]
        public object FullTitle { get; set; }

        [JsonProperty("type")]
        public object Type { get; set; }

        [JsonProperty("year")]
        public object Year { get; set; }

        [JsonProperty("image")]
        public object Image { get; set; }

        [JsonProperty("releaseDate")]
        public object ReleaseDate { get; set; }

        [JsonProperty("runtimeMins")]
        public object RuntimeMins { get; set; }

        [JsonProperty("runtimeStr")]
        public object RuntimeStr { get; set; }

        [JsonProperty("plot")]
        public object Plot { get; set; }

        [JsonProperty("plotLocal")]
        public object PlotLocal { get; set; }

        [JsonProperty("plotLocalIsRtl")]
        public bool PlotLocalIsRtl { get; set; }

        [JsonProperty("awards")]
        public object Awards { get; set; }

        [JsonProperty("directors")]
        public object Directors { get; set; }

        [JsonProperty("directorList")]
        public object DirectorList { get; set; }

        [JsonProperty("writers")]
        public object Writers { get; set; }

        [JsonProperty("writerList")]
        public object WriterList { get; set; }

        [JsonProperty("stars")]
        public object Stars { get; set; }

        [JsonProperty("starList")]
        public object StarList { get; set; }

        [JsonProperty("actorList")]
        public object ActorList { get; set; }

        [JsonProperty("fullCast")]
        public object FullCast { get; set; }

        [JsonProperty("genres")]
        public object Genres { get; set; }

        [JsonProperty("genreList")]
        public object GenreList { get; set; }

        [JsonProperty("companies")]
        public object Companies { get; set; }

        [JsonProperty("companyList")]
        public object CompanyList { get; set; }

        [JsonProperty("countries")]
        public object Countries { get; set; }

        [JsonProperty("countryList")]
        public object CountryList { get; set; }

        [JsonProperty("languages")]
        public object Languages { get; set; }

        [JsonProperty("languageList")]
        public object LanguageList { get; set; }

        [JsonProperty("contentRating")]
        public object ContentRating { get; set; }

        [JsonProperty("imDbRating")]
        public object ImDbRating { get; set; }

        [JsonProperty("imDbRatingVotes")]
        public object ImDbRatingVotes { get; set; }

        [JsonProperty("metacriticRating")]
        public object MetacriticRating { get; set; }

        [JsonProperty("ratings")]
        public object Ratings { get; set; }

        [JsonProperty("wikipedia")]
        public object Wikipedia { get; set; }

        [JsonProperty("posters")]
        public object Posters { get; set; }

        [JsonProperty("images")]
        public object Images { get; set; }

        [JsonProperty("trailer")]
        public object Trailer { get; set; }

        [JsonProperty("boxOffice")]
        public object BoxOffice { get; set; }

        [JsonProperty("tagline")]
        public object Tagline { get; set; }

        [JsonProperty("keywords")]
        public object Keywords { get; set; }

        [JsonProperty("keywordList")]
        public object KeywordList { get; set; }

        [JsonProperty("similars")]
        public object Similars { get; set; }

        [JsonProperty("tvSeriesInfo")]
        public object TvSeriesInfo { get; set; }

        [JsonProperty("tvEpisodeInfo")]
        public object TvEpisodeInfo { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }
    }

### Main Models
The main models we plan to inlcude are:
* [IMDb Movie]
public class ImdbMovie
    {
        
        public string Id { get; set; }
        public string Title { set; get; }
        public string OriginalTitle { get; set; }
        public string FullTitle { set; get; }
        public string Year { set; get; }
        public string ReleaseDate { set; get; }
        public string RuntimeMins { set; get; }
        public string RuntimeStr { set; get; }
        public string Plot { set; get; } // IMDb Plot allways en, TMDb Plot translate
        public string PlotLocal { set; get; }
        public bool PlotLocalIsRtl { set; get; }
        public string Awards { set; get; }
        public string Image { get; set; }
        public string Type { set; get; }
        public string Directors { set; get; }
        public List<StarShort> DirectorList { get; set; }
        public string Writers { set; get; }
        public List<StarShort> WriterList { get; set; }
        public string Stars { set; get; }
        public List<StarShort> StarList { get; set; }
        public List<ActorShort> ActorList { get; set; }
        public FullCastData FullCast { get; set; }
        public string Genres { set; get; }
        public List<KeyValuePair<string, string>> GenreList { get; set; }
        public string Companies { get; set; }
        public List<CompanyShort> CompanyList { get; set; }
        public string Countries { set; get; }
        public List<KeyValuePair<string, string>> CountryList { set; get; }
        public string Languages { set; get; }
        public List<KeyValuePair<string, string>> LanguageList { set; get; }
        public string ContentRating { get; set; }
        public string IMDbRating { get; set; }
        public string IMDbRatingVotes { get; set; }
        public string MetacriticRating { set; get; }
        public RatingData Ratings { set; get; }
        public WikipediaData Wikipedia { set; get; }
        public PosterData Posters { get; set; }
        public ImageData Images { get; set; }
        public TrailerData Trailer { get; set; }
        public BoxOfficeShort BoxOffice { get; set; }
        public string Tagline { get; set; }
        public string Keywords { get; set; }
        public List<string> KeywordList { get; set; }
        public List<SimilarShort> Similars { get; set; }
        public TvSeriesInfo TvSeriesInfo { get; set; }
        public TvEpisodeInfo TvEpisodeInfo { get; set; }
        public string ErrorMessage { get; set; }
    }
* public class RatingData
    {
        
        
        public string IMDbId { get; set; }
        public string Title { get; set; }
        public string FullTitle { get; set; }
        public string Type { get; set; }
        public string Year { get; set; }

        public string IMDb { get; set; }
        public string Metacritic { get; set; }
        public string TheMovieDb { get; set; }
        public string RottenTomatoes { get; set; }
        public string TV_com { get; set; }
        public string FilmAffinity { get; set; }

        public string ErrorMessage { get; set; }
    }

## Team Composition
The team is made up of:
* Devin Lally - Part-time MSIS Student, Full-Time Technical Account Associate
  * [LinkedIn](https://www.linkedin.com/in/devinlally/)
* Erika Avilés González - Full-time MSIS Student
  * [LinkedIn](https://www.linkedin.com/in/erikaavilesglz/)
* Joseph Ross - Full-time MSIS Student
  * [LinkedIn](https://www.linkedin.com/in/joseph-ross-88104a91/)
  
  The team meets on _Thursdays 8pm_ via teams.
  

