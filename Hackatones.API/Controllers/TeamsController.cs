using Hackatones.API.Data;
using Hackatones.Shered.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hackatones.API.Controllers
{

    [ApiController]
    [Route("api/team")]
    public class TeamsController : ControllerBase
    {
        private readonly DataContext _context;

        public TeamsController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Teams.ToListAsync());
        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var team = await _context.Teams.FirstOrDefaultAsync(x => x.Id == id);
            if (team == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(team);
            }
        }


        [HttpPost]
        public async Task<ActionResult> Post(Team team)
        {
            _context.Add(team);
            await _context.SaveChangesAsync();
            return Ok(new
            {
                message = "Equipo creado.",
                data = team
            });
        }

        //Actualizar 
        [HttpPut]
        public async Task<ActionResult> Put(Team team)
        {
            _context.Teams.Update(team);
            await _context.SaveChangesAsync();
            return Ok(new
            {
                message = "Se actualizo equipo.",
                data = team
            });
        }

        // Eliminar 
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var teamDelete = await _context.Teams
                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();

            if (teamDelete == 0)
            {
                return NotFound(new { message = "Equipo no encontrado." });
            }
            else
            {
                return Ok(new { message = "Equipo  eliminado." });
            }
        }
    }
}