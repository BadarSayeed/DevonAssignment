using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevonAssignment.Model
{
    public class DetailsModel
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public List<string> Skills { get; set; }
    }
}