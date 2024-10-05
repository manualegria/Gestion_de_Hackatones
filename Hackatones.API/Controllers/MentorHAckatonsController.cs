using Hackatones.API.Data;
using Hackatones.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hackatones.API.Controllers
{

    [ApiController]
    [Route("api/MentorHAckatons")]
    public class MentorHAckatonsController: ControllerBase
    {
        private readonly DataContext _context;

        public MentorHAckatonsController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.MentorHackatons.ToListAsync());
        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var MentorHAckaton = await _context.MentorHackatons.FirstOrDefaultAsync(x => x.id == id);

            if (MentorHAckaton == null)
            {

                return NotFound();
            }
            else
            {

                return Ok(MentorHAckaton);
            }

        }

        [HttpPost]
        public async Task<ActionResult> Post(MentorHackaton mentorhackaton)
        {
            _context.Add(mentorhackaton);

            await _context.SaveChangesAsync();

            return Ok( mentorhackaton);

        }


        //Actualizar 
        [HttpPut]
        public async Task<ActionResult> Put(MentorHackaton mentorHackaton)
        {
            _context.MentorHackatons.Update(mentorHackaton);
            await _context.SaveChangesAsync();
            return Ok( mentorHackaton);

        }


        // Eliminar 
        [HttpDelete("{id:int}")]

        public async Task<ActionResult> Delete(int id)
        {

            var Delete = await _context.MentorHackatons
                .Where(x => x.id == id)
                .ExecuteDeleteAsync();

            if (Delete == 0)
            {



                return NotFound();
            }
            else
            {

                return Ok(Delete);
            }



        }
    }
}
