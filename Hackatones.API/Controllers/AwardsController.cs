using Hackatones.API.Data;
using Hackatones.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hackatones.API.Controllers
{

    [ApiController]
    [Route("api/award")]
    public class AwardsController: ControllerBase
    {

        private readonly DataContext _context;

        public AwardsController(DataContext context) 
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Awards.ToListAsync());
        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var award = await _context.Awards.FirstOrDefaultAsync(x => x.Id == id);

            if (award == null)
            {

                return NotFound();
            }
            else
            {
               
                return Ok(award);
            }

        }

        [HttpPost]
        public async Task<ActionResult> Post(Award award)
        {
            _context.Add(award);

            await _context.SaveChangesAsync();

            return Ok(new
            {
                message = "Premio creado con éxito.",
                data = award
            });

        }


        //Actualizar 
        [HttpPut]
        public async Task<ActionResult> Put(Award award)
        {
            _context.Awards.Update(award);
            await _context.SaveChangesAsync();
            return Ok(new
            {
                message = "Premio actualizado con éxito.",
                data = award
            });

        }


        // Eliminar 
        [HttpDelete("{id:int}")]

        public async Task<ActionResult> Delete(int id)
        {

            var awardDelete = await _context.Awards
                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();

            if (awardDelete == 0)
            {



                return NotFound(new { message = "Premio no encontrado." });
            }
            else
            {

                return Ok(new { message = "Premio eliminado con éxito." });
            }



        }
    }
}
