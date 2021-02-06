using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourChallenge.Data
{
    class Post
    {
        public Guid OwnerId { get; set; }
        public int PostId { get; set; }
        public string Title { get; set; }
        public string  PostText { get; set; }
        public int CommentId { get; set; }
        public string CommentText { get; set; }

        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }

    }
}
