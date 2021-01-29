using DevonAssignment.Enums;
using DevonAssignment.Model;
using DevonAssignment.Themes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevonAssignment.Themes.Theme
{
    public class BlueTheme : ITheme
    {
        public ThemeModel GetThemeDetails()
        {
            ThemeModel theme = new ThemeModel()
            {
                BackgroundColor = Colors.blue.GetDescription(),
                FontColor = Colors.yellow.GetDescription(),
                FontFamily =  FontFamily.Verdana.GetDescription()
            };

            return theme;
        }
    }
}