using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Threading.Tasks;


namespace Infrastructure.Data.Postgres.Repositories
{
    public class TweetRepository : Repository<Tweet, int>, ITweetRepository
    {
        public TweetRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }

        public async Task<IList<Tweet>> GetAdvertByIdAsync(int id)
        {
            return await PostgresContext.Set<Tweet>()
                .Include(Tweet => Tweet.Id)
                .Where(Tweet => Tweet.Id == id)
                .ToListAsync();
        }
        public async Task<IList<Tweet>> GetAllAsync(Expression<Func<Tweet, bool>>? filter = null)
        {
            var Tweet = PostgresContext.Set<Tweet>()
            .Include(user => user.User);

            return filter == null
                ? await Tweet.ToListAsync()
                : await Tweet.Where(filter)
                .ToListAsync();
        }

    }
}