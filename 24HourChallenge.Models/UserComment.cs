using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourChallenge.Models
{
    public class UserComment
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(UserPost.Id))]
        public int CommentId { get; set; } //this is prolly set up wrong

        [Required]
        public string Text { get; set; }

        public virtual List<Reply> Replies { get; set; } = new List<Reply>();

        [Required]
        public Guid Author { get; set; } //using user id
    }
}
