
using Hackatones.API.Data;
using Hackatones.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hackatones.API.Controllers
{


    [ApiController]
    [Route("api/project")]
    public class ProjectsController: ControllerBase
    {

        private readonly DataContext _context;


        public ProjectsController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Projects.ToListAsync());
        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var project = await _context.Projects.FirstOrDefaultAsync(x => x.Id == id);

            if (project == null)
            {

                return NotFound();
            }
            else
            {

                return Ok(project);
            }

        }

        [HttpPost]
        public async Task<ActionResult> Post(Project project)
        {
            _context.Add(project);

            await _context.SaveChangesAsync();

            return Ok(new
            {
                message = "Proyecto creado con éxito.",
                data = project
            });

        }


        //Actualizar 
        [HttpPut]
        public async Task<ActionResult> Put(Project project)
        {
            _context.Projects.Update(project);
            await _context.SaveChangesAsync();
            return Ok(new
            {
                message = "Proyecto actualizado con éxito.",
                data = project
            });

        }


        // Eliminar 
        [HttpDelete("{id:int}")]

        public async Task<ActionResult> Delete(int id)
        {

            var projectDelete = await _context.Projects
                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();

            if (projectDelete == 0)
            {



                return NotFound(new { message = "Proyecto no encontrado." });
            }
            else
            {

                return Ok(new { message = "Proyecto eliminado con éxito." });
            }



        }
    }
}
