using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesActorsDbDto.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MoviesActorsDbDto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        public MainDbContext Context { get; }
        public MoviesController(MainDbContext context)
        {
            Context = context;
        }


        [HttpGet]
        public ActionResult<List<Movie>> Get()
        {
            //return Ok(Context.Movies.ToList());
            #region Noura
            var movies = Context.Movies.Include(m => m.Actors).ToList();

            if (movies.Count == 0)
            {
                return NotFound();
            }
            List<MovieWithActorsNamesDto> Movies = new List<MovieWithActorsNamesDto>();
            foreach (var mov in movies)
            {
                Movies.Add(new MovieWithActorsNamesDto
                {
                    Id = mov.Id,
                    Name = mov.Name,
                    Type = mov.Type,
                    Duration = mov.Duration,
                    Rate = mov.Rate,
                    Producer = mov.Producer
                });
                var thisMovie =  Movies.Find(m => m.Name == mov.Name);
                foreach (var act in mov.Actors)
                {
                    thisMovie.Actors.Add(act.Name);
                }

            }
            return Ok(Movies);
            #endregion
        }


        [HttpGet("{id:int}")]
        public ActionResult<Movie> GetById(int id)
        {
            var movie = Context.Movies.Include(m=>m.Actors).FirstOrDefault(m=>m.Id == id);

            if (movie == null)
            {
                return NotFound();
            }
            //return Ok(movie);

            MovieWithActorsNamesDto movieDto = new MovieWithActorsNamesDto
            {
                Id = movie.Id,
                Name = movie.Name,
                Type = movie.Type,
                Duration = movie.Duration,
                Rate = movie.Rate,
                Producer = movie.Producer
            };
            foreach (var act in movie.Actors)
            {
                movieDto.Actors.Add(act.Name);
            }

            return Ok(movieDto);
        }


        [HttpGet("{name:alpha}")]
        public ActionResult<Movie> GetByName(string name)
        {
            var movie = Context.Movies.Include(m => m.Actors).FirstOrDefault(m => m.Name == name);

            if (movie == null)
            {
                return NotFound();
            }
            //return Ok(movie);

            MovieWithActorsNamesDto movieDto = new MovieWithActorsNamesDto
            {
                Id = movie.Id,
                Name = movie.Name,
                Type = movie.Type,
                Duration = movie.Duration,
                Rate = movie.Rate,
                Producer = movie.Producer
            };
            foreach (var act in movie.Actors)
            {
                movieDto.Actors.Add(act.Name);
            }

            return Ok(movieDto);
        }


        [HttpPost]
        public ActionResult<Movie> Post(MovieWithoutActorsDto movie)
        {
            if (movie == null)
            {
                return BadRequest();
            }
            Movie Movie = new Movie
            {
                Name = movie.Name,
                Type = movie.Type,
                Duration = movie.Duration,
                Rate = movie.Rate,
                Producer = movie.Producer
            };
            Context.Movies.Add(Movie);
            Context.SaveChanges();
            return Ok();
            //return CreatedAtAction(nameof(GetById), new { id = movie.Id }, movie);
        }


        [HttpPut("{id}")]
        public ActionResult Put(int id, MovieWithoutActorsDto movie)
        {
            if (id != movie.Id)
            {
                return BadRequest();
            }

            //Context.Entry(movie).State = EntityState.Modified;
            Movie Movie = Context.Movies.FirstOrDefault(m=>m.Id == id);
            if (Movie == null)
                return NotFound();
            //return BadRequest("This movie doesn't exist in the list");
            
            else {
                Movie.Name = movie.Name;
                Movie.Type = movie.Type;
                Movie.Duration = movie.Duration;
                Movie.Rate = movie.Rate;
                Movie.Producer = movie.Producer;
                Context.SaveChanges();
                //return NoContent();
                return Ok(Movie);
            }

        }



        [HttpDelete("{id}")]
        public ActionResult<List<Movie>> Delete(int id)
        {
            var movie = Context.Movies.Find(id);

            if (movie == null)
            {
                return NotFound();
            }

            Context.Movies.Remove(movie);
            Context.SaveChanges();

            var movies = Context.Movies.ToList();

            return Ok();
        }


    }
}
