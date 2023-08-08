using Business.Models.Request;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;

namespace Business.Utilities.Mapping;

public class Profiles : AutoMapper.Profile
{
    public Profiles()
    {
        CreateMap<RegisterDto, User>();

        CreateMap<User, UserProfileDto>();
        CreateMap<UserUpdateDto, User>();

        CreateMap<Tweet, TweetInfoDto>();
        CreateMap<TweetUpdateDto, Tweet>();
        CreateMap<TweetCreateDto, Tweet>();

    }
}