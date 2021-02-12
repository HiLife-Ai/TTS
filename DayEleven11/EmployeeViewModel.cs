using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DayEleven.Models
{
    public class EmployeeViewModel
    {

        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public int DepartmentID { get; set; }
        public string Address { get; set; }

        public bool DepartmentName { get; set; }



    }
}