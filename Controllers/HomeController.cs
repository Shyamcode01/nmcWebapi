using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NmcWbapi.model;

namespace NmcWbapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ApplicationDbContex _dbcontext;
        public HomeController(ApplicationDbContex context)
        {
            _dbcontext = context; 
        }

        [HttpGet]
        public async Task<ActionResult<List<nmcStudent>>> getlist()
        {
            var daa=await _dbcontext.nmcStudents.ToListAsync();
            return Ok(daa);

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<nmcStudent>>Getbyid(int id)
        {
            var data=await _dbcontext.nmcStudents.FindAsync(id);
            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }

        [HttpPost]
        public async Task<ActionResult<nmcStudent>> createdata(nmcStudent std)
        {
            await _dbcontext.nmcStudents.AddAsync(std);
            await _dbcontext.SaveChangesAsync();
            return Ok();
        }

        [HttpPost("{id}")]
        public async Task<ActionResult<nmcStudent>> update(int id ,nmcStudent std)
        {
            if (id != std.id)
            {
                return BadRequest();
            }
            _dbcontext.nmcStudents.Update(std);
            _dbcontext.SaveChanges();
            return Ok(std);
        }
        [HttpDelete("{id}")]

        public async Task<ActionResult<nmcStudent>> deletedata(int id)
        {
            var std = await _dbcontext.nmcStudents.FindAsync(id);
            if(std == null)
            {
                return NotFound();
            }
            _dbcontext.nmcStudents.Remove(std);
            await _dbcontext.SaveChangesAsync();
            return Ok();
        }



    }
}
