using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace DevonAssignment.Enums
{
    public enum FontFamily
    {
        [Description("Segoe UI")]
        SegoeUI,
        Verdana,
        [Description("Times New Roman")]
        TimesNewRoman,
        Arial
    }
}