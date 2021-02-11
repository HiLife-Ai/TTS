using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day6.Models
{
    public class D6Class
    {
        public int EmployeeID { get; set; }
        public string EmpName { get; set; }
        public Nullable<int> DepartmentID { get; set; }
        public string Address { get; set; }

        public string DepartmentName { get; set; }
    }
}