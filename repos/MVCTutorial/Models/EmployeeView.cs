using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTutorial.Models
{
    public class EmployeeView
    {
        public int FloorID { get; set; }
        public string FloorName { get; set; }
        public Nullable<int> TotalCount { get; set; }
        public string RoomCount { get; set; }

        public virtual Table1 Table1 { get; set; }

    }
}