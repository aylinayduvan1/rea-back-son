using Business.Models.Response;
using Business.Services.Base;
using Business.Services.Base.Interface;
using Business.Services.Interface;
using Business.Utilities.Mapping.Interface;
using Infrastructure.Data.Postgres;
using Infrastructure.Data.Postgres.Entities;
using System.Threading.Tasks;

namespace Business.Services;

public class TweetService : BaseService<Tweet, int, TweetInfoDto>, ITweetService
{
    public TweetService(IUnitOfWork unitOfWork, IMapperHelper mapperHelper) : base(unitOfWork, unitOfWork.Tweets, mapperHelper)
    {
    }
}