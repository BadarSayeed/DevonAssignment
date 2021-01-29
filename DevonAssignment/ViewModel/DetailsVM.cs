using DevonAssignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevonAssignment.ViewModel
{
    public class DetailsVM
    {
        public string ThemeColor { get; set; }
        public ThemeModel ThemeDetails { get; set; }
        public DetailsModel Details { get; set; }
    }
}