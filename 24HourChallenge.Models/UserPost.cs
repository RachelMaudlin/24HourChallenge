using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourChallenge.Models
{
    public class UserPost
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Title { get; set; }
        
        [Required]
        public string Text { get; set; }

        public virtual List<UserComment> Comments { get; set; } = new List<UserComment>();

        [Required]
        public Guid Author { get; set; }
    }
}
