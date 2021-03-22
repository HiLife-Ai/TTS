using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModelBind.Models
{
    public class ViewModel
    {
        public int EmpId { get; set; }

        [Required(ErrorMessage="Enter Name")]
        public string EmpName { get; set; }

        [Required(ErrorMessage ="Enter Department")]
        public int  DepartmentId { get; set; }

        [Required(ErrorMessage ="Enter Address")]
        public string Address { get; set; }

        //custom attribute
        public string DepartmentName { get; set; }
        public bool Remember { get; set; }
        public string SName { get; set; }

    }
}