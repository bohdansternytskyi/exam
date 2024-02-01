using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test.DAL;
using Test.DTOs;

namespace Test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly MainDbContext _context;
        public UsersController(MainDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetUser([FromQuery] int id)
        {
            var result = await _context.Users.Where(x => x.Id == id).FirstOrDefaultAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody] UserDTO user)
        {
            var newUser = new User { Name = user.Name, Surname = user.Surname };
            await _context.Users.AddAsync(newUser);
            await _context.SaveChangesAsync();
            return Ok(newUser);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUser([FromQuery] int id)
        {
            var user = await _context.Users.Where(x => x.Id == id).AsNoTracking().FirstOrDefaultAsync();
            _context.Users.Remove(user);
            _context.SaveChanges();
            return NoContent();
        }
    }
}