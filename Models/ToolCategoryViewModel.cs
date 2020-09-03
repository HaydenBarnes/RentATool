using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace RentATool1.Models
{
    public class ToolCategoryViewModel
    {
        public List<Tool> Tools { get; set; }
        public SelectList Category { get; set; }
        public string ToolCategory { get; set; }
        public string SearchString { get; set; }

    }
}
