using Hackatones.API.Data;
using Hackatones.Shered.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hackatones.API.Controllers
{

    [ApiController]
    [Route("api/teamparticipant")]
    public class TeamParticipantsController : ControllerBase
    {
        private readonly DataContext _context;

        public TeamParticipantsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.TeamParticipants.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var teamparticipant = await _context.TeamParticipants.FirstOrDefaultAsync(x => x.Id == id);
            if (teamparticipant == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(teamparticipant);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post(TeamParticipant teamparticipant)
        {
            _context.Add(teamparticipant);
            await _context.SaveChangesAsync();
            return Ok(new
            {
                message = "Participante ingresado al equipo.",
                data = teamparticipant
            });
        }

        //Actualizar 
        [HttpPut]
        public async Task<ActionResult> Put(TeamParticipant teamparticipant)
        {
            _context.TeamParticipants.Update(teamparticipant);
            await _context.SaveChangesAsync();
            return Ok(new
            {
                message = "Se actualizo equipo con el nuevo participante.",
                data = teamparticipant
            });
        }

        //Eliminar
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var teamparticipantDelete = await _context.TeamParticipants
                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();

            if (teamparticipantDelete == 0)
            {
                return NotFound(new { message = "Participante de equipo no encontrado." });
            }
            else
            {
                return Ok(new { message = "Participante de equipo eliminado." });
            }
        }
    }
}
