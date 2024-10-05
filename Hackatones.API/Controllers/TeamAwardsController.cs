using Hackatones.API.Data;
using Hackatones.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hackatones.API.Controllers
{
    [ApiController]
    [Route("api/awardteams")]
    public class TeamAwardsController: ControllerBase
    {
        private readonly DataContext _context;

        public TeamAwardsController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.TeamAwards.ToListAsync());
        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var teamaward = await _context.TeamAwards.FirstOrDefaultAsync(x => x.Id == id);

            if (teamaward == null)
            {

                return NotFound();
            }
            else
            {

                return Ok(teamaward);
            }

        }

        [HttpPost]
        public async Task<ActionResult> Post(TeamAward teamAward)
        {
            _context.Add(teamAward);

            await _context.SaveChangesAsync();

            return Ok(teamAward);

        }


        //Actualizar 
        [HttpPut]
        public async Task<ActionResult> Put(TeamAward teamAward)
        {
            _context.TeamAwards.Update(teamAward);
            await _context.SaveChangesAsync();
            return Ok(teamAward);

        }


        // Eliminar 
        [HttpDelete("{id:int}")]

        public async Task<ActionResult> Delete(int id)
        {

            var teamAward = await _context.TeamAwards
                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();

            if (teamAward == 0)
            {



                return NotFound();
            }
            else
            {

                return Ok(teamAward);
            }



        }
    }
}
