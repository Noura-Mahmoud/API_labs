using Microsoft.EntityFrameworkCore;

namespace MoviesActorsDbDto.Models
{
    public class MainDbContext: DbContext
    {
        public MainDbContext(DbContextOptions options): base(options)
        {

        }
        public virtual DbSet<Movie> Movies { get;set; }
        public virtual DbSet<Actor> Actors { get;set; }
    }
}
