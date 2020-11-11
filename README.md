# IS7024 Movie Application

## Introduction

How often you find a movie summary and think is good only to watch it and find out it is not as good? Does having popular actors/actresses in a movie makes it good? What is the average rating of all the actors in the movie? Our app will be a simple way for users to make decisions regarding their movie choices and continue to feed back into our niche communicty by providing their ranking.

Users will be able to do the following:

•	Search for movies ratings

•	Search for movie showtimes

•	Search for actors/actresses’ ratings

•	Provide their own feedback regarding movies and actors


## Requirements
As a user, I want to be able to quickly search the ratings of a movie and the actors/actresses featured in it so that I can decide if I want to see it or not.
Another way to decide what movie to watch will be by reviewing the top 10 rated movies in the app's ranking.

Once the user has decided what movie they want to watch, the user will be able to get the movie showtimes within their area.

Finally, the user will be able to provide their own rating for the movie they just watched.

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


![Fandango Image]data:image/png;base64,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)
Our second data souce will be [Fandango](https://developer.fandango.com/docs/read/Fandango).

Fandango is the nation's leading moviegoer destination, sells tickets to nearly 20,000 screens nationwide. Through Fandango's API we can get real-time data via a web service accessible through REST (Representational State Transfer). The standard model of a web service is employed: a client makes a request through a REST URL and data is returned to the client as an XML-formatted stream of text.

### Example of Model Information
![Fandango Showtime Example](https://raw.githubusercontent.com/devinmarie/7024Movies/master/fandango_info.png)

### Main Models
The main models we plan to inlcude are:
* [Showtimes](https://developer.fandango.com/docs/read/fandango/API__Showtime_Methods)
* [Movies](https://developer.fandango.com/docs/read/fandango/API__Movie_Methods)

## Team Composition
The team is made up of:
* Devin Lally - Part-time MSIS Student, Full-Time Technical Account Associate
  * [LinkedIn](https://www.linkedin.com/in/devinlally/)
* Erika Avilés González - Full-time MSIS Student
  * [LinkedIn](https://www.linkedin.com/in/erikaavilesglz/)
* Joseph Ross - Full-time MSIS Student
  * [LinkedIn](https://www.linkedin.com/in/joseph-ross-88104a91/)
  
  The team meets on _Thursdays 8pm_ via teams.
  

