using DevonAssignment.Enums;
using DevonAssignment.Themes.Interfaces;
using DevonAssignment.Themes.Theme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevonAssignment.Themes.Factory
{
    public class ThemeFactory
    {
        public ITheme GetThemeObject(string themeName)
        {
            ITheme themeObject = null;

            Colors selectedTheme;

            Enum.TryParse<Colors>(themeName.ToLower(), out selectedTheme);

            switch (selectedTheme)
            {
                case Colors.black:
                    themeObject = new BlackTheme();
                    break;
                case Colors.blue:
                    themeObject = new BlueTheme();
                    break;
                case Colors.green:
                    themeObject = new GreenTheme();
                    break;
                case Colors.red:
                    themeObject = new RedTheme();
                    break;
                default:
                    themeObject = new BlackTheme();
                    break;
            }

            return themeObject;

        }
    }
}