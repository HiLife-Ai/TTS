using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultiSelectCheckBox.ViewModel
{
    public class SkillViewModel
    {
        public int SkillId { get; set; }
        public string SkillName { get; set; }
        public bool IsChecked { get; set; }
    }
}