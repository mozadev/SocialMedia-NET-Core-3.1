using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Core.Entities;
using SocialMedia.Infrastruct.Repositories;

namespace SocialMedia.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPosts() 
        {
            var posts = new PostRepository().GetPosts();
            // return a 200 status code with the posts
            return Ok(posts);
        }
    }
}
