using DockerMicroservice.DAL;
using DockerMicroservice.Models;
using Microsoft.EntityFrameworkCore;

namespace DockerMicroservice
{
    public class CRUDService : ICRUDService
    {
        private readonly MicroserviceDBContext _context;


        public CRUDService(MicroserviceDBContext context)
        {
            _context = context;
        }

        public async Task<BlogPost> CreatePost(BlogPost post)
        {
            var result = await _context.Posts.AddAsync(post);
            await _context.SaveChangesAsync();

            return result.Entity;
        }

        public async Task<List<BlogPost>> GetAllPosts()
        {
            var result = await  _context.Posts.ToListAsync();

            return result;
        }
    }
}
