using _24HourChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourChallenge.Services
{
    public class PostService
    {
        private readonly Guid _userID; 

        public PostService(Guid userID)
        {
            _userID = userID;
        }

        public bool CreatePost(UserPost model)
        {
            var entity =
                new UserPost()
                {
                    Id = model.Id,
                    Title = model.Title,
                    Text = model.Text,
                    Comments = model.Comments,
                    Author = _userID, 
                };
              
           
        }
       
    }
}
