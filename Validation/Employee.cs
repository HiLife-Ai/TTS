//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Binding2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public string Address { get; set; }
    
        public virtual Department Department { get; set; }
    }
}
