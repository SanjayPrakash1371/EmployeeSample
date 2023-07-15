using EmployeeSample.Controllers.Request;

using EmployeeSample.DataBaseConnect;
using EmployeeSample.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly AllDataAccess allDataAccess;
        public EmployeeController(AllDataAccess dataAccess)
        {
            allDataAccess=dataAccess;
        }

        

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> get()
        {

            return await allDataAccess.Employees.ToListAsync();
            
        }

        [HttpPost]

        public async Task<ActionResult<Employee>> addEmployee(RequestEmployee requestEmployee)
        {
            Employee employee = new Employee();
            employee.EmployeeId = requestEmployee.EmployeeId;

            employee.Name = requestEmployee.Name;
            employee.emailId = requestEmployee.emailId;
            employee.password = requestEmployee.password;
            employee.designation = requestEmployee.designation;


            UsernamePassword usernamePassword = new UsernamePassword();
            usernamePassword.Password = requestEmployee.password;
            usernamePassword.emailID = requestEmployee.emailId;

            employee.UsernamePassword = usernamePassword;

            

            foreach (var roleID in requestEmployee.roles)
            {
                EmployeeRoles employeeRole = new EmployeeRoles();
               

                employeeRole.rId = roleID;

                employeeRole.role = await allDataAccess.Roles.FindAsync(roleID);

                employeeRole.rolename = employeeRole.role.Name;

                employeeRole.empId = requestEmployee.EmployeeId;
                await allDataAccess.EmployeesRoles.AddAsync(employeeRole);
               

            }
            await allDataAccess.Employees.AddAsync(employee);

            await allDataAccess.SaveChangesAsync();







            return Ok(employee);


        }






    }
}
