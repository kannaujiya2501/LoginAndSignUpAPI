using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API.model;
using Microsoft.EntityFrameworkCore;
namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegisterController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public RegisterController(ApplicationDbContext db)
        {
            _db=db;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Register>>> GetRegister()
        {
            return await _db.Register.ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<IEnumerable<Register>>> PostRegister(Register register)

        {
            // return await _db.Register.ToListAsync();
            _db.Register.Add(register);
            await _db.SaveChangesAsync();
            return Ok();
        }
    }
}