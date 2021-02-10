using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day9.Models
{
    public class CustomerViewModel
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public Nullable<int> Phoneno { get; set; }
        public int MobileID { get; set; }

        public string Mobiletype { get; set; }
    }
}