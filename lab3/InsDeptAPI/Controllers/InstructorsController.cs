using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InsDeptAPI.Models;

namespace InsDeptAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorsController : ControllerBase
    {
        private readonly InsDeptDbContextAPI _context;

        public InstructorsController(InsDeptDbContextAPI context)
        {
            _context = context;
        }

        // GET: api/Instructors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Instructor>>> GetInstructors()
        {
          if (_context.Instructors == null)
          {
              return NotFound();
          }
            return await _context.Instructors.ToListAsync();
        }

        // GET: api/Instructors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Instructor>> GetInstructor(int id)
        {
          if (_context.Instructors == null)
          {
              return NotFound();
          }
            var instructor = await _context.Instructors.FindAsync(id);

            if (instructor == null)
            {
                return NotFound();
            }

            return instructor;
        }
        [HttpGet("{name:alpha}")]
        public async Task<ActionResult<Instructor>> GetInstructorByName(String name)
        {
            if (_context.Instructors == null)
            {
                return NotFound();
            }
            var instructor = await _context.Instructors.FirstOrDefaultAsync(i=>i.Name == name);

            if (instructor == null)
            {
                return NotFound();
            }

            return instructor;
        }

        // PUT: api/Instructors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInstructor(int id, Instructor instructor)
        {
            if (id != instructor.Id)
            {
                return BadRequest();
            }

            _context.Entry(instructor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InstructorExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Instructors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Instructor>> PostInstructor(Instructor instructor)
        {
          if (_context.Instructors == null)
          {
              return Problem("Entity set 'InsDeptDbContextAPI.Instructors'  is null.");
          }
         // if (_context.Instructors.FirstOrDefault(i=>i.Name == instructor.Name && i.Email == instructor.Email)== null)
          if (_context.Instructors.FirstOrDefault(i=>i.SSN == instructor.SSN)== null)
            {
                //_context.Instructors.Add(instructor);
                _context.Instructors.Add(new Instructor()
                {
                SSN = instructor.SSN,
                Name = instructor.Name,
                Address = instructor.Address,
                Age = instructor.Age,
                Phone = instructor.Phone,
                Email = instructor.Email,
                Password = instructor.Password,
                Salary = instructor.Salary,
                DOB = instructor.DOB
                });
                await _context.SaveChangesAsync();

                return Created("GetInstructors", null);
                //return CreatedAtAction("GetInstructor", new { id = instructor.Id }, instructor);
            }
          else
            return BadRequest("Already exists");
        }

        // DELETE: api/Instructors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInstructor(int id)
        {
            if (_context.Instructors == null)
            {
                return NotFound();
            }
            var instructor = await _context.Instructors.FindAsync(id);
            if (instructor == null)
            {
                return NotFound();
            }

            _context.Instructors.Remove(instructor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InstructorExists(int id)
        {
            return (_context.Instructors?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
