
using System;
using SocialMedia.Core.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SocialMedia.Infrastruct.Repositories
{
    public class PostRepository
    {
        public IEnumerable<Post>GetPosts()
        {
            var posts = Enumerable.Range(1, 10).Select(x => new Post
            {
                PostId = x,
                Description = $"Description {x}",
                Date = DateTime.Now,
                Image = $"http://misapis.com/{x}",
                UserId = x *2 ,
            }

            );
            return posts;
        }

    }
}
