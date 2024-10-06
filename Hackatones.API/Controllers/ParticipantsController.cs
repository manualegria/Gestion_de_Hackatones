using Hackatones.API.Data;
using Hackatones.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hackatones.API.Controllers
{

    [ApiController]
    [Route("api/participant")]
    public class ParticipantsController : ControllerBase
    {
        private readonly DataContext _context;

        public ParticipantsController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Participants.ToListAsync());
        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var participant = await _context.Participants.FirstOrDefaultAsync(x => x.Id == id);
            if (participant == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(participant);
            }
        }


        [HttpPost]
        public async Task<ActionResult> Post(TeamParticipant participant)
        {
            _context.Add(participant);
            await _context.SaveChangesAsync();
            return Ok(new
            {
                message = "Participante ingresado.",
                data = participant
            });
        }

        //Actualizar 
        [HttpPut]
        public async Task<ActionResult> Put(Participant participant)
        {
            _context.Participants.Update(participant);
            await _context.SaveChangesAsync();
            return Ok(new
            {
                message = "Se actualizo participante.",
                data = participant
            });
        }

        // Eliminar 
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var participantDelete = await _context.Participants
                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();

            if (participantDelete == 0)
            {
                return NotFound(new { message = "Participante no encontrado." });
            }
            else
            {
                return Ok(new { message = "Participante  eliminado." });
            }
        }
    }
}