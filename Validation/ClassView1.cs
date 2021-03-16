
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Binding2.Models
{
    public class ClassView1
    {
        public int EmpId { get; set; }

        [Required(ErrorMessage ="Enter Name")]
        public string EmpName { get; set; }

        [Required(ErrorMessage = "Enter Department")]
        public Nullable<int> DepartmentId { get; set; }

        [Required(ErrorMessage = "Enter Address")]
        public string Address { get; set; }

        //custom attribute
        public string DepartmentName { get; set; }
        public bool Remember { get; set; }

    }
}