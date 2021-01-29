using DevonAssignment.Enums;
using DevonAssignment.Model;
using DevonAssignment.Themes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevonAssignment.Themes.Theme
{
    public class BlackTheme : ITheme
    {
        public ThemeModel GetThemeDetails()
        {
            ThemeModel theme = new ThemeModel()
            {
                BackgroundColor = Colors.black.GetDescription(),
                FontColor = Colors.red.GetDescription(),
                FontFamily = FontFamily.SegoeUI.GetDescription()
            };

            return theme;
        }
    }
}