using Hackatones.API.Data;
using Hackatones.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hackatones.API.Controllers
{

    [ApiController]
    [Route("api/TeamMentors")]
    public class TeamMentorsController: ControllerBase
    {

        private readonly DataContext _context;

        public TeamMentorsController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.TeamMentors.ToListAsync());
        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var teamMentor = await _context.TeamAwards.FirstOrDefaultAsync(x => x.Id == id);

            if (teamMentor == null)
            {

                return NotFound();
            }
            else
            {

                return Ok(teamMentor);
            }

        }

        [HttpPost]
        public async Task<ActionResult> Post(TeamMentor teamMentor)
        {
            _context.Add(teamMentor);

            await _context.SaveChangesAsync();

            return Ok(teamMentor);

        }


        //Actualizar 
        [HttpPut]
        public async Task<ActionResult> Put(TeamMentor teamMentor)
        {
            _context.TeamMentors.Update(teamMentor);
            await _context.SaveChangesAsync();
            return Ok(teamMentor);

        }


        // Eliminar 
        [HttpDelete("{id:int}")]

        public async Task<ActionResult> Delete(int id)
        {

            var teammentor = await _context.TeamMentors
                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();

            if (teammentor == 0)
            {



                return NotFound();
            }
            else
            {

                return Ok(teammentor);
            }



        }
    }
}
