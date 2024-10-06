using Hackatones.API.Data;
using Hackatones.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hackatones.API.Controllers
{

    [ApiController]
    [Route("api/hackatonteam")]
    public class HackatonTeamsController : ControllerBase
    {
        private readonly DataContext _context;

        public HackatonTeamsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.HackatonTeams.ToListAsync());
        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var hackatonteam = await _context.HackatonTeams.FirstOrDefaultAsync(x => x.Id == id);
            if (hackatonteam == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(hackatonteam);
            }
        }


        [HttpPost]
        public async Task<ActionResult> Post(HackatonTeam hackatonteam)
        {
            _context.Add(hackatonteam);
            await _context.SaveChangesAsync();
            return Ok(new
            {
                message = "Se regristro equipo en hackaton.",
                data = hackatonteam
            });
        }

        //Actualizar 
        [HttpPut]
        public async Task<ActionResult> Put(HackatonTeam hackatonteam)
        {
            _context.HackatonTeams.Update(hackatonteam);
            await _context.SaveChangesAsync();
            return Ok(new
            {
                message = "Se Actulizo equipo en hackaton.",
                data = hackatonteam
            });
        }

        // Eliminar 
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {

            var hackatonteamDelete = await _context.HackatonTeams
                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();

            if (hackatonteamDelete == 0)
            {
                return NotFound(new { message = "Equipo no encontrado en hackaton." });
            }
            else
            {
                return Ok(new { message = "Equipo eliminado de la hackaton." });
            }
        }
    }
}