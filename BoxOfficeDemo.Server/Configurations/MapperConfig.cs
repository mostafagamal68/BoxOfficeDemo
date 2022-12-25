using AutoMapper;
using BoxOfficeDemo.Server.Models;
using BoxOfficeDemo.Shared.Configurations;
using BoxOfficeDemo.Shared.DTO.Account;
using BoxOfficeDemo.Shared.Models;

namespace BoxOfficeDemo.Server.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<WatchList, SingleWatchList>().ReverseMap();
            CreateMap<WatchListList, WatchList>().ReverseMap()
                .ForMember(m => m.MovieName, o => o.MapFrom(f => f.Movie.MovieName))
                .ForMember(m => m.Image, o => o.MapFrom(f => f.Movie.Image));
            CreateMap<Movie, SingleMovie>().ReverseMap();
            CreateMap<Movie, MoviesList>().ReverseMap();
            CreateMap<Review, SingleReview>().ReverseMap();
            CreateMap<Review, ReviewsList>().ReverseMap();
            CreateMap<ReviewsList, Review>().ReverseMap()
                .ForMember(m => m.FirstName, o => o.MapFrom(f => f.User.FirstName))
                .ForMember(m => m.LastName, o => o.MapFrom(f => f.User.LastName));
            CreateMap<User, UserForRegistrationDto>().ReverseMap();
            //CreateMap<LoggedUser, User>().ReverseMap();
        }
    }
}
