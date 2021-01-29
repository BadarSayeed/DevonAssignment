using DevonAssignment.Enums;
using DevonAssignment.Themes.Factory;
using DevonAssignment.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevonAssignment.Controllers
{
    public class HomeController : Controller
    {
        ThemeFactory _factory;
        public HomeController()
        {
            _factory = new ThemeFactory();
        }
        public ActionResult Index(DetailsVM model)
        {
            model.ThemeColor = string.IsNullOrEmpty(model.ThemeColor) ? Colors.black.ToString() : model.ThemeColor;
            var theme = _factory.GetThemeObject(model.ThemeColor);
            model.ThemeDetails = theme.GetThemeDetails();
            return View(model);
        }
               
    }
}