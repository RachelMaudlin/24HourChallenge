using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourChallenge.Data
{
     public class Post
    {
        [Key]
        public Guid OwnerId { get; set; }
        [Required]
        public int PostId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string  PostText { get; set; }
        [Required]
        public int CommentId { get; set; }
        [Required]
        public string CommentText { get; set; }
        [Required]

       
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }


    }
}
