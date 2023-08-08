using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request
{
    public class TweetCreateDto
    {
        public string Content { get; set; }
        public int UserId { get; set; } // Hangi kullanıcıya ait

    }
}
