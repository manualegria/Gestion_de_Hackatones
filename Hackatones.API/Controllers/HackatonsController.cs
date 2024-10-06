using Hackatones.API.Data;
using Hackatones.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hackatones.API.Controllers
{

    [ApiController]
    [Route("api/hackaton")]
    public class HackatonsController : ControllerBase
    {
        private readonly DataContext _context;

        public HackatonsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Hackatons.ToListAsync());
        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var hackaton = await _context.Hackatons.FirstOrDefaultAsync(x => x.Id == id);
            if (hackaton == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(hackaton);
            }
        }


        

        //Actualizar 
        [HttpPut]
        public async Task<ActionResult> Put(Hackaton hackaton)
        {
            _context.Hackatons.Update(hackaton);
            await _context.SaveChangesAsync();
            return Ok(new
            {
                message = "Se Actulizo hackaton.",
                data = hackaton
            });
        }

        // Eliminar 
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {

            var hackatonDelete = await _context.Hackatons
                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();

            if (hackatonDelete == 0)
            {
                return NotFound(new { message = "NO se encontrado hackaton." });
            }
            else
            {
                return Ok(new { message = "Se a eliminado la hackaton." });
            }
        }
    }
}
//..