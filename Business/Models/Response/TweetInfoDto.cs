using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class TweetInfoDto
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; } // Hangi kullanıcıya ait

        public UserProfileDto User { get; set; }

        public DateTime CreatedAt { get; set; }



    }
}
