namespace EmployeeSample.Controllers.Request
{
    public class RequestEmployee
    {
        public string EmployeeId { get; set; }

        public string Name { get; set; }

        public string emailId { get; set; }

        public string password { get; set; }

        public string designation { get; set; }

       public  List<int> roles { get; set; }
    }
}
