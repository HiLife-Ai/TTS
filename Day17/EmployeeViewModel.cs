﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Day17.Models
{
    public class EmployeeViewModel
    {

    

        public int EmployeeId { get; set; }

   

        public string Name { get; set; }

 

        public Nullable<int> DepartmentId { get; set; }


        public string Address { get; set; }


        public string DepartmentName { get; set; }
        public bool remember { get; set; }

    }
}