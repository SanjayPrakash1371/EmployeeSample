using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeSample.Models
{
    public class Employee
    {
        public int Id { get; set; }


        public string EmployeeId { get; set; }

        public string Name { get; set; }

        public string emailId { get; set; }

        public string password { get; set; }

        public string designation { get; set; }

       /* [DisplayName("IdOfUsernamePassword")]
        public int? upId { get; set; }*/

        [ForeignKey("UserPass")]
        public UsernamePassword UsernamePassword { get; set; }

        /*[ForeignKey("IdOfRole")]
        public EmployeeRoles? employeeRoles { get; set; }*/











    }
}
