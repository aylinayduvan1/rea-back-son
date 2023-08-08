using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Tweet   : Entity<int>
    {
        public string Content { get; set; }
        public int UserId { get; set; } // Hangi kullanıcıya ait


        public User User { get; set; } // Hangi kullanıcıya ait
    }

}