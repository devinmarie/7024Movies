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


![Fandango Image](https://images.fandango.com/r1.0.940/redesign/areas/staticpages/img/linktous/logos/1050x171.gif)
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
  

