using System.Collections.Generic;
using System.Threading.Tasks;
using College.Infrastructure.DB;
using College.Model.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace College.Api.Controllers
{
    [Route("api/colleges")]
    [ApiController]
    public class CollegeController : ControllerBase
    {
        private readonly CollegeAppContext _context;
        public CollegeController(CollegeAppContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CollegeInstitution>>> GetInstitutions()
        {
            var institutions = await _context.CollegeInstitutions.ToListAsync();

            return Ok(institutions);
        }

        [HttpPost]
        public async Task<ActionResult> AddInstitution(CollegeInstitution collegeInstitution)
        {
            await _context.AddAsync(collegeInstitution);

            await _context.SaveChangesAsync();

            return StatusCode(201);
        }
    }
}