using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using repos.Datingapp.API.Data;
using repos.Datingapp.API.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace repos.Datingapp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }
        // api/user/3
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUser()
        {
            return await _context.Users.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            return await _context.Users.FindAsync(id);
        }
    }
}