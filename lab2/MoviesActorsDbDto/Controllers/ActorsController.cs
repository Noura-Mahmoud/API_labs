using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesActorsDbDto.Models;
using System.Collections.Generic;

namespace MoviesActorsDbDto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorsController : ControllerBase
    {
        public MainDbContext Context { get; }
        public ActorsController(MainDbContext _context)
        {
            Context = _context;
        }


        [HttpGet]
        public ActionResult<List<Actor>> GetAll()
        {
            List<Actor> Actors = Context.Actors.Include(a=>a.Movie).ToList();
            if (Actors.Count == 0)
            {
                return NotFound();
            }

            List<ActorsWithMovieNameDto> actors = new List<ActorsWithMovieNameDto>();
            foreach (var act in Actors)
            {
                actors.Add(new ActorsWithMovieNameDto
                {
                    Id = act.Id,
                    Name = act.Name,
                    Gender = act.Gender,
                    Age = act.Age,
                    Address = act.Address,
                    Salary = act.Salary,
                    MovieName = act.Movie.Name
                });
            }
            return Ok(actors);
        }


        [HttpGet]
        [Route("{id:int}", Name ="GetOneByID")]
        public ActionResult<Actor> GetByID(int id)
        {
            var Actor = Context.Actors.Include(a => a.Movie).FirstOrDefault(a => a.Id == id);
            if (Actor == null)
            {
                return NotFound();
            }
            ActorsWithMovieNameDto actorDto = new ActorsWithMovieNameDto();
            actorDto.Name = Actor.Name;
            actorDto.Salary = Actor.Salary;
            actorDto.Gender = Actor.Gender;
            actorDto.Address = Actor.Address;
            actorDto.MovieName = Actor.Movie.Name;
            return Ok(actorDto);
            #region old

            //var actor = Context.Actors.FirstOrDefault(a => a.Id == id);
            //var actor = Context.Actors.Find(id);
            //if (actor == null)
            //    return NotFound();

            //return Ok(actor); 
            #endregion
        }

        [HttpGet]
        [Route("{name:alpha}")]
        public ActionResult<Actor> GetByName(string name)
        {
            var Actor = Context.Actors.FirstOrDefault(a => a.Name.ToLower() == name.ToLower());
            if (Actor == null)
            {
                return NotFound();
            }

            ActorsWithMovieNameDto actorDto = new ActorsWithMovieNameDto();
            actorDto.Name = Actor.Name;
            actorDto.Salary = Actor.Salary;
            actorDto.Gender = Actor.Gender;
            actorDto.Address = Actor.Address;
            actorDto.MovieName = Actor.Movie.Name;
            return Ok(actorDto);
        }

        [HttpPost]
        public ActionResult<Actor> Post(ActorWithMovieIdDto actor)
        {
            //if (actor == null)
            //{
            //    return BadRequest();
            //}
            if (Context.Movies.Find(actor.MovieId) == null)
                return NotFound();
            Actor newActor = new Actor
            {
                //Id = actor.Id,
                Name = actor.Name,
                Salary = actor.Salary,
                Gender = actor.Gender,
                Address = actor.Address,
                Age = actor.Age,
                MovieId = actor.MovieId
            };
            
            Context.Actors.Add(newActor);
            Context.SaveChanges();

            return Ok();//created
            //return StatusCode(201);//created
            //string url = Url.Link("GetOneByID", new { id = actor.Id });
            //return Created(url, actor);
        }


        [HttpPut("{id}")]
        public ActionResult Put(int id, ActorWithMovieIdDto actor)
        {
            if (id != actor.Id)
            {
                return BadRequest();
            }

            var updatedActor = Context.Actors.FirstOrDefault(a => a.Id == id);
            if (updatedActor == null)
                return BadRequest("There is no actor with such id");
            else
            {
                updatedActor.Name = actor.Name;
                updatedActor.Salary = actor.Salary;
                updatedActor.Gender = actor.Gender;
                updatedActor.Address = actor.Address;
                updatedActor.Age = actor.Age;
                updatedActor.MovieId = actor.MovieId;
                Context.SaveChanges();
                return NoContent();
                //return Ok();
            }

        }


        [HttpDelete("{id}")]
        public ActionResult<List<Actor>> Delete(int id)
        {
            var actor = Context.Actors.Find(id);

            if (actor == null)
            {
                return NotFound();
            }

            Context.Actors.Remove(actor);
            Context.SaveChanges();

            var actors = Context.Actors.ToList();

            return Ok();
        }

    }
}
