using Hackatones.API.Data;
using Hackatones.Shared.Entities;
using Hackatones.Shered.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hackatones.API.Controllers
{
    [ApiController]
    [Route("api/mentores")]
    public class MentorsController : ControllerBase
    {

        private readonly DataContext _context;


        public MentorsController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Mentors.ToListAsync());
        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var project = await _context.Mentors.FirstOrDefaultAsync(x => x.Id == id);

            if (project == null)
            {

                return NotFound();
            }
            else
            {

                return Ok(project);
            }

        }

        [HttpPost]
        public async Task<ActionResult> Post(Mentor mentor)
        {
            _context.Add(mentor);

            await _context.SaveChangesAsync();

            return Ok(new
            {
                message = "Mentor creado con éxito.",
                data = mentor
            });

        }


        //Actualizar 
        [HttpPut]
        public async Task<ActionResult> Put(Mentor mentor)
        {
            _context.Mentors.Update(mentor);
            await _context.SaveChangesAsync();
            return Ok(new
            {
                message = "Mentor actualizado con éxito.",
                data = mentor
            });

        }


        // Eliminar 
        [HttpDelete("{id:int}")]

        public async Task<ActionResult> Delete(int id)
        {

            var mentorDelete = await _context.Mentors
                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();

            if (mentorDelete == 0)
            {

                return NotFound(new { message = "MEntor no encontrado." });
            }
            else
            {

                return Ok(new { message = "Mentor eliminado con éxito." });
            }



        }
    }
}