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
            // create a new instance of the PostRepository class
            var posts = new PostRepository().GetPosts();
            return Ok(posts);
             
        }
    }
}
