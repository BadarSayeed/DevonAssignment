using DevonAssignment.Enums;
using DevonAssignment.Model;
using DevonAssignment.Themes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevonAssignment.Themes.Theme
{
    public class RedTheme : ITheme
    {
        public ThemeModel GetThemeDetails()
        {
            ThemeModel theme = new ThemeModel()
            {
                BackgroundColor = Colors.red.GetDescription(),
                FontColor = Colors.black.GetDescription(),
                FontFamily = FontFamily.Arial.GetDescription(),
            };

            return theme;
        }
    }
}