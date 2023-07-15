using EmployeeSample.DataBaseConnect;
using EmployeeSample.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly AllDataAccess allDataAccess;
        public RoleController(AllDataAccess dataAccess)
        {
            allDataAccess = dataAccess;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Role>>> get()
        {

            return await allDataAccess.Roles.ToListAsync();

        }

        [HttpPost]
        public async Task<ActionResult<Role>> add(Role role)
        {
            await allDataAccess.Roles.AddAsync(role);
            await allDataAccess.SaveChangesAsync();

            return Ok(role);
        }

    }
}
