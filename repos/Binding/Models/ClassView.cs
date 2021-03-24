﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Binding.Models
{
    public class ClassView
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int DepartmentId { get; set; }
        public string Address { get; set; }

        //Custom attribute
        public string DepartmentName { get; set; }
        public bool Remember { get; set; }
    }
}