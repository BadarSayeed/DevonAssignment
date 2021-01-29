using DevonAssignment.Enums;
using DevonAssignment.Model;
using DevonAssignment.Themes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevonAssignment.Themes.Theme
{
    public class GreenTheme : ITheme
    {
        public ThemeModel GetThemeDetails()
        {
            ThemeModel theme = new ThemeModel()
            {
                BackgroundColor = Colors.green.GetDescription(),
                FontColor = Colors.orange.GetDescription(),
                FontFamily = FontFamily.TimesNewRoman.GetDescription(),
            };

            return theme;
        }
    }
}