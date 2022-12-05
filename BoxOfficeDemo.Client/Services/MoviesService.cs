using System.IO;
using System.Net.Http.Json;
using System.Text.Json;
using BoxOfficeDemo.Shared.Models;

namespace BoxOfficeDemo.Client.Services
{
    public class MoviesService : IMoviesService
    {
        private readonly HttpClient _client;
        //private readonly JsonSerializerOptions _options;
        public MoviesService(HttpClient Client) => _client = Client;
        //this._client.BaseAddress = new Uri();
        //_options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        public List<MoviesList> MoviesList { get; set; } = new();
        //public SingleMovie Movie { get; set; } = new();

        //var response = await _client.GetAsync("Movies/GetMovies");
        //var content = await response.Content.ReadAsStringAsync();
        //if (!response.IsSuccessStatusCode)
        //{
        //    throw new ApplicationException(content);
        //}
        //var movies = JsonSerializer.Deserialize<List<MoviesList>>(content, _options);
        //return movies;
        public async Task GetMovies()
            => MoviesList = await _client.GetFromJsonAsync<List<MoviesList>>("Movies");

        public async Task<SingleMovie> GetMovie(decimal? id)
            => await _client.GetFromJsonAsync<SingleMovie>($"Movies/{id}");

        public async Task SaveMovie(SingleMovie movie)
            => await _client.PostAsJsonAsync("Movies/SaveMovie",movie);
        public async Task DeleteMovie(decimal? id)
        { 
            var respone = await _client.DeleteAsync($"Movies/DeleteMovie/{id}");
            if(respone.IsSuccessStatusCode)
                MoviesList.Remove(MoviesList.Where(c => c.MovieID == id).FirstOrDefault());
        }
        //    List<BoxOffice> Movies = new List<BoxOffice>();

        //    public MoviesService()
        //    {
        //        Movies = new List<BoxOffice>
        //        {
        //            new BoxOffice{ ID=1,MovieName="The Invitation"
        //            , Image="/images/TheInvitation.jpg", ReleasedDate= new DateTime(2022, 8, 26)
        //            , Description="A young woman is courted and swept off her feet, only to realize a gothic conspiracy is afoot."
        //            , ParentalGuide=13, Genere="Horror"
        //            , Length=new TimeOnly(1, 45), Rate=5.3
        //            , Director="Jessica M. Thompson"
        //            , Writer="Blair Butler"
        //            , Stars=new List<string>{ "Nathalie Emmanuel", "Thomas Doherty", "Stephanie Corneliussen" } },

        //        new BoxOffice{ ID=2,MovieName="Bullet Train"
        //            , Image="/images/BulletTrain.jpg"
        //            , Description="Five assassins aboard a fast moving bullet train find out their missions have something in common."
        //            , ReleasedDate= new DateTime(2022, 8, 5)
        //            , ParentalGuide=15, Genere="Action"
        //            , Length=new TimeOnly(2, 07), Rate=7.5
        //            , Director="David Leitch"
        //            , Writer="Zak Olkewicz"
        //            , Stars=new List<string>{ "Brad PittJoey", "KingAaron", "Taylor-Johnson" }},

        //        new BoxOffice{ ID=3,MovieName="Beast"
        //            , Image="/images/Beast.jpg"
        //            , Description="A father and his two teenage daughters find themselves hunted by a massive rogue lion intent on proving that the Savanna has but one apex predator."
        //            , ReleasedDate= new DateTime(2022, 8, 19)
        //            , ParentalGuide=16, Genere="Drama"
        //            , Length=new TimeOnly(1, 33), Rate=5.9
        //            , Director="Baltasar Kormákur"
        //            , Writer="Ryan Engle"
        //            , Stars=new List<string>{ "Liyabuya Gongo", "Martin Munro", "Daniel Hadebe" }},

        //        new BoxOffice{ ID=4,MovieName="Top Gun: Maverick"
        //            , Image="/images/TopGunMaverick.jpg"
        //            , Description="After more than thirty years of service as one of the Navy's top aviators, Pete Mitchell is where he belongs, pushing the envelope as a courageous test pilot and dodging the advancement in rank that would ground him."
        //            , ReleasedDate= new DateTime(2022, 5, 27)
        //            , ParentalGuide=13, Genere="Action"
        //            , Length=new TimeOnly(1, 33), Rate=8.5
        //            , Director="Joseph Kosinski"
        //            , Writer="Jim Cash"
        //            , Stars=new List<string>{ "Tom Cruise", "Val Kilmer", "Miles Teller" }},

        //        new BoxOffice{ ID=5,MovieName="Dragon Ball Super: Super Hero"
        //            , Image="/images/DragonBallSuperSuperHero.jpg"
        //            , Description="The Red Ribbon Army from Goku's past has returned with two new androids to challenge him and his friends."
        //            , ReleasedDate= new DateTime(2022, 8, 18)
        //            , ParentalGuide=13, Genere="Animation"
        //            , Length=new TimeOnly(1, 40), Rate=7.3
        //            , Director="Tetsuro Kodama"
        //            , Writer="Akira Toriyama"
        //            , Stars=new List<string>{ "Masako Nozawa", "Toshio Furukawa", "Yûko Minaguchi" }},

        //        new BoxOffice{ ID=6,MovieName="DC League of Super-Pets"
        //            , Image="/images/DCLeagueofSuperPets.jpg/"
        //            , Description="Krypto the Super-Dog and Superman are inseparable best friends, sharing the same superpowers and fighting crime side by side in Metropolis. However, Krypto must master his own powers for a rescue mission when Superman is kidnapped."
        //            , ReleasedDate= new DateTime(2022, 7, 29)
        //            , ParentalGuide=7, Genere="Animation"
        //            , Length=new TimeOnly(1, 45), Rate=7.6
        //            , Director="Jared Stern"
        //            , Writer="John Whittington"
        //            , Stars=new List<string>{ "Dwayne Johnson", "Dwayne Johnson", "Kate McKinnon" }},

        //        new BoxOffice{ ID=7,MovieName="Three Thousand Years of Longing"
        //            , Image="/images/ThreeThousandYearsofLonging.jpg"
        //            , Description="A lonely scholar, on a trip to Istanbul, discovers a Djinn who offers her three wishes in exchange for his freedom."
        //            , ReleasedDate= new DateTime(2022, 8, 26)
        //            , ParentalGuide=15, Genere="Drama"
        //            , Length=new TimeOnly(1, 48), Rate=6.9
        //            , Director="George Miller"
        //            , Writer="Augusta Gore"
        //            , Stars=new List<string>{ "Tilda Swinton", "Idris Elba", "Pia Thunderbolt" }},

        //        new BoxOffice{ ID=8,MovieName="Minions: The Rise of Gru"
        //            , Image="/images/MinionsTheRiseofGru.jpg"
        //            , Description="The untold story of one twelve-year-old's dream to become the world's greatest supervillain."
        //            , ReleasedDate= new DateTime(2022, 7, 1)
        //            , ParentalGuide=7, Genere="Animation"
        //            , Length=new TimeOnly(1, 27), Rate=6.6
        //            , Director="Kyle Balda"
        //            , Writer="Matthew Fogel"
        //            , Stars=new List<string>{ "Steve Carell", "Pierre Coffin", "Alan Arkin" }},

        //        new BoxOffice{ ID=9,MovieName="Thor: Love and Thunder"
        //            , Image="/images/ThorLoveandThunder.jpg"
        //            , Description="Thor enlists the help of Valkyrie, Korg and ex-girlfriend Jane Foster to fight Gorr the God Butcher, who intends to make the gods extinct."
        //            , ReleasedDate= new DateTime(2022, 7, 8)
        //            , ParentalGuide=13, Genere="Action"
        //            , Length=new TimeOnly(1, 58), Rate=6.7
        //            , Director="Taika Waititi"
        //            , Writer="Jennifer Kaytin Robinson"
        //            , Stars=new List<string>{ "Chris Hemsworth", "Natalie Portman", "Christian Bale" }},

        //        new BoxOffice{ ID=10,MovieName="Where the Crawdads Sing"
        //            , Image="/images/WheretheCrawdadsSing.jpg"
        //            , Description="A woman who raised herself in the marshes of the deep South becomes a suspect in the murder of a man she was once involved with."
        //            , ReleasedDate= new DateTime(2022, 7, 15)
        //            , ParentalGuide=13, Genere="Drama"
        //            , Length=new TimeOnly(2, 5), Rate=7.1
        //            , Director="Olivia Newman"
        //            , Writer="Delia Owens"
        //            , Stars=new List<string>{ "Daisy Edgar-Jones", "Taylor John Smith", "Harris Dickinson" }}
        //        };
        //    }

        //    public List<BoxOfficeList> GetMovies() => Movies.Select(s => new BoxOfficeList
        //    {
        //        ID = s.ID,
        //        MovieName = s.MovieName.Length > 15 ? s.MovieName.Substring(0, 13).Insert(13, "..") : s.MovieName,
        //        Genere = s.Genere,
        //        Image = s.Image,
        //        Length = s.Length,
        //        ParentalGuide = s.ParentalGuide,
        //        Rate = s.Rate,
        //        ReleasedDate = s.ReleasedDate
        //    }).ToList();

        //    public BoxOffice GetMovie(int id) => Movies.FirstOrDefault(f => f.ID == id);
    }
}

