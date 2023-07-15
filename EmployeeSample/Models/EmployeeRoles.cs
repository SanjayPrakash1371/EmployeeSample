using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeSample.Models
{
    public class EmployeeRoles
    {

        public int id { get; set; }

        public string rolename { get; set; }


        /*[DisplayName("IdOfEmployee")]
        public int empId { get; set; }*/

        /*[ForeignKey("EmployeeId")]*/
        public string empId { get; set; }

        [DisplayName("IdOfRole")]
        public int rId { get; set; }

        [ForeignKey("RoleId")]
        public Role role { get; set; }


    }
}
