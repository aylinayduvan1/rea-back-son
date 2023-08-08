using Business.Models.Request;
using Business.Models.Response;
using Business.Services.Base.Interface;
using Business.Services.Interface;
using Infrastructure.Data.Postgres.Entities;
using System.Threading.Tasks;
using Web.Controllers.Base;
namespace Web.Controllers;

public class TweetController : BaseCRUDController<Tweet, int, TweetCreateDto, TweetUpdateDto, TweetInfoDto>
{
    public TweetController(ITweetService service) : base(service)
    {
    }
}