using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourChallenge.Models
{
    public class UserReply
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public string Text { get; set; }
        //either do this as a class like you've started or...
        //have it inherit from the comment class.
        //If enough time then try option 2 for practice.
    }
}
