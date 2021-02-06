using _24HourChallenge.Data;
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

        public bool CreatePost(Post model)
        {
            var entity =
                new Post()
                {
                    OwnerId = _userID,
                    PostId = model.PostId,
                    Title = model.Title,
                    PostText = model.PostText,
                    CommentId = model.CommentId,
                    CommentText = model.CommentText,
                    CreatedUtc = DateTimeOffset.Now,
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Posts.Add(entity);
                return ctx.SaveChanges() == 1;
            }

        }
       
        
    }
}
