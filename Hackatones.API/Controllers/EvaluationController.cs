using Hackatones.API.Data;
using Hackatones.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Hackatones.API.Controllers
{

    [ApiController]
    [Route("api/evaluation")]
    public class EvaluationController: ControllerBase
    {
        private readonly DataContext _context;

        public EvaluationController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Evaluations.ToArrayAsync());
        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var evaluation = await _context.Evaluations.FirstOrDefaultAsync(x => x.Id == id);

            if (evaluation == null)
            {

                return NotFound();
            }
            else
            {
                
                return Ok(evaluation);
            }

        }

        [HttpPost]
        public async Task<ActionResult> Post(Evaluation evaluation)
        {
            _context.Add(evaluation);

            await _context.SaveChangesAsync();

            return Ok(new
            {
                message = "Evaluacion creada con éxito.",
                data = evaluation
            });

        }


        //Actualizar 
        [HttpPut]
        public async Task<ActionResult> Put(Evaluation evaluation)
        {
            _context.Evaluations.Update(evaluation);
            await _context.SaveChangesAsync();
            return Ok(new
            {
                message = "Evaluacion actualizada con éxito.",
                data = evaluation
            });

        }


        // Eliminar 
        [HttpDelete("{id:int}")]

        public async Task<ActionResult> Delete(int id)
        {

            var evaluationDelete = await _context.Evaluations
                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();

            if (evaluationDelete == 0)
            {



                return NotFound(new { message = "Evaluacion no encontrada." });
            }
            else
            {

                return Ok(new { message = "Evaluacion eliminada con éxito." });
            }



        }
    }
}
