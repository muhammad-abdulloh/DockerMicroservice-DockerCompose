using DockerMicroservice.Models;
using Microsoft.EntityFrameworkCore;

namespace DockerMicroservice.DAL
{
    public class MicroserviceDBContext : DbContext
    {
        public MicroserviceDBContext(DbContextOptions<MicroserviceDBContext> options) : base(options)
        {
            Database.Migrate();
        }

        public virtual DbSet<BlogPost> Posts { get; set; }
    }
}
