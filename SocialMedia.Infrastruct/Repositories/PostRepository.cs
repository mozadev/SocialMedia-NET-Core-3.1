using SocialMedia.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Infrastruct.Repositories
{
    public class PostRepository
    {
        public IEnumerable<Post>GetPosts()
        {
            var posts = Enumerable.Empty<Post>();
        }

    }
}
