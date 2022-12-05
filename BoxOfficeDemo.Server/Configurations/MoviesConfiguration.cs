using BoxOfficeDemo.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BoxOfficeDemo.Server.Configurations
{
    public class MoviesConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasData
            (
                new Movie
                {
                    MovieID = 0.00000001M,
                    MovieName = "The Invitation"
                    ,
                    Image = "/images/TheInvitation.jpg",
                    ReleasedDate = new DateTime(2022, 8, 26)
                    ,
                    Description = "A young woman is courted and swept off her feet, only to realize a gothic conspiracy is afoot."
                    ,
                    ParentalGuide = 13,
                    Genere = "Horror"
                    ,
                    Length = new TimeSpan(0, 1, 45, 0),
                    Rate = 5.3M
                    ,
                    Director = "Jessica M. Thompson"
                    ,
                    Writer = "Blair Butler"
                    ,
                    Stars = "Nathalie Emmanuel," + "Thomas Doherty," + "Stephanie Corneliussen"
                },

                new Movie
                {
                    MovieID = 0.00000002M,
                    MovieName = "Bullet Train"
                    ,
                    Image = "/images/BulletTrain.jpg"
                    ,
                    Description = "Five assassins aboard a fast moving bullet train find out their missions have something in common."
                    ,
                    ReleasedDate = new DateTime(2022, 8, 5)
                    ,
                    ParentalGuide = 15,
                    Genere = "Action"
                    ,
                    Length = new TimeSpan(0, 2, 07, 0),
                    Rate = 7.5M
                    ,
                    Director = "David Leitch"
                    ,
                    Writer = "Zak Olkewicz"
                    ,
                    Stars = "Brad PittJoey, " + "KingAaron, " + "Taylor-Johnson"
                },

                new Movie
                {
                    MovieID = 0.00000003M,
                    MovieName = "Beast"
                    ,
                    Image = "/images/Beast.jpg"
                    ,
                    Description = "A father and his two teenage daughters find themselves hunted by a massive rogue lion intent on proving that the Savanna has but one apex predator."
                    ,
                    ReleasedDate = new DateTime(2022, 8, 19)
                    ,
                    ParentalGuide = 16,
                    Genere = "Drama"
                    ,
                    Length = new TimeSpan(0, 1, 33, 0),
                    Rate = 5.9M
                    ,
                    Director = "Baltasar Kormákur"
                    ,
                    Writer = "Ryan Engle"
                    ,
                    Stars = "Liyabuya Gongo, " + "Martin Munro, " + "Daniel Hadebe"
                },

                new Movie
                {
                    MovieID = 0.00000004M,
                    MovieName = "Top Gun: Maverick"
                    ,
                    Image = "/images/TopGunMaverick.jpg"
                    ,
                    Description = "After more than thirty years of service as one of the Navy's top aviators, Pete Mitchell is where he belongs, pushing the envelope as a courageous test pilot and dodging the advancement in rank that would ground him."
                    ,
                    ReleasedDate = new DateTime(2022, 5, 27)
                    ,
                    ParentalGuide = 13,
                    Genere = "Action"
                    ,
                    Length = new TimeSpan(0, 1, 33, 0),
                    Rate = 8.5M
                    ,
                    Director = "Joseph Kosinski"
                    ,
                    Writer = "Jim Cash"
                    ,
                    Stars = "Tom Cruise, " + "Val Kilmer, " + "Miles Teller"
                },

                new Movie
                {
                    MovieID = 0.00000005M,
                    MovieName = "Dragon Ball Super: Super Hero"
                    ,
                    Image = "/images/DragonBallSuperSuperHero.jpg"
                    ,
                    Description = "The Red Ribbon Army from Goku's past has returned with two new androids to challenge him and his friends."
                    ,
                    ReleasedDate = new DateTime(2022, 8, 18)
                    ,
                    ParentalGuide = 13,
                    Genere = "Animation"
                    ,
                    Length = new TimeSpan(0, 1, 40, 0),
                    Rate = 7.3M
                    ,
                    Director = "Tetsuro Kodama"
                    ,
                    Writer = "Akira Toriyama"
                    ,
                    Stars = "Masako Nozawa, " + "Toshio Furukawa, " + "Yûko Minaguchi"
                },

                new Movie
                {
                    MovieID = 0.00000006M,
                    MovieName = "DC League of Super-Pets"
                    ,
                    Image = "/images/DCLeagueofSuperPets.jpg/"
                    ,
                    Description = "Krypto the Super-Dog and Superman are inseparable best friends, sharing the same superpowers and fighting crime side by side in Metropolis. However, Krypto must master his own powers for a rescue mission when Superman is kidnapped."
                    ,
                    ReleasedDate = new DateTime(2022, 7, 29)
                    ,
                    ParentalGuide = 7,
                    Genere = "Animation"
                    ,
                    Length = new TimeSpan(0, 1, 45, 0),
                    Rate = 7.6M
                    ,
                    Director = "Jared Stern"
                    ,
                    Writer = "John Whittington"
                    ,
                    Stars = "Dwayne Johnson, " + "Dwayne Johnson, " + "Kate McKinnon"
                },

                new Movie
                {
                    MovieID = 0.00000007M,
                    MovieName = "Three Thousand Years of Longing"
                    ,
                    Image = "/images/ThreeThousandYearsofLonging.jpg"
                    ,
                    Description = "A lonely scholar, on a trip to Istanbul, discovers a Djinn who offers her three wishes in exchange for his freedom."
                    ,
                    ReleasedDate = new DateTime(2022, 8, 26)
                    ,
                    ParentalGuide = 15,
                    Genere = "Drama"
                    ,
                    Length = new TimeSpan(0, 1, 48, 0),
                    Rate = 6.9M
                    ,
                    Director = "George Miller"
                    ,
                    Writer = "Augusta Gore"
                    ,
                    Stars = "Tilda Swinton, " + "Idris Elba, " + "Pia Thunderbolt"
                },

                new Movie
                {
                    MovieID = 0.00000008M,
                    MovieName = "Minions: The Rise of Gru"
                    ,
                    Image = "/images/MinionsTheRiseofGru.jpg"
                    ,
                    Description = "The untold story of one twelve-year-old's dream to become the world's greatest supervillain."
                    ,
                    ReleasedDate = new DateTime(2022, 7, 1)
                    ,
                    ParentalGuide = 7,
                    Genere = "Animation"
                    ,
                    Length = new TimeSpan(0, 1, 27, 0),
                    Rate = 6.6M
                    ,
                    Director = "Kyle Balda"
                    ,
                    Writer = "Matthew Fogel"
                    ,
                    Stars = "Steve Carell, " + "Pierre Coffin, " + "Alan Arkin"
                },

                new Movie
                {
                    MovieID = 0.00000009M,
                    MovieName = "Thor: Love and Thunder"
                    ,
                    Image = "/images/ThorLoveandThunder.jpg"
                    ,
                    Description = "Thor enlists the help of Valkyrie, Korg and ex-girlfriend Jane Foster to fight Gorr the God Butcher, who intends to make the gods extinct."
                    ,
                    ReleasedDate = new DateTime(2022, 7, 8)
                    ,
                    ParentalGuide = 13,
                    Genere = "Action"
                    ,
                    Length = new TimeSpan(0, 1, 58, 0),
                    Rate = 6.7M
                    ,
                    Director = "Taika Waititi"
                    ,
                    Writer = "Jennifer Kaytin Robinson"
                    ,
                    Stars = "Chris Hemsworth, " + "Natalie Portman, " + "Christian Bale"
                },

                new Movie
                {
                    MovieID = 0.00000010M,
                    MovieName = "Where the Crawdads Sing"
                    ,
                    Image = "/images/WheretheCrawdadsSing.jpg"
                    ,
                    Description = "A woman who raised herself in the marshes of the deep South becomes a suspect in the murder of a man she was once involved with."
                    ,
                    ReleasedDate = new DateTime(2022, 7, 15)
                    ,
                    ParentalGuide = 13,
                    Genere = "Drama"
                    ,
                    Length = new TimeSpan(0, 2, 5, 0),
                    Rate = 7.1M
                    ,
                    Director = "Olivia Newman"
                    ,
                    Writer = "Delia Owens"
                    ,
                    Stars = "Daisy Edgar-Jones, " + "Taylor John Smith, " + "Harris Dickinson"
                }
            );
        }
    }
}
