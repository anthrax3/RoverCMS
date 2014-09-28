using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using System.Web.Mvc;

namespace Retro_CMS.Infrastructure.View
{
    public class CustomViewEngine : RazorViewEngine
    {
        public CustomViewEngine()
        {
            const string themeName = "Default";

            ViewLocationFormats = new[]
            {
                "~/Themes/" + themeName + "/Views/{1}/{0}.cshtml",
                "~/Themes/" + themeName + "/Views/Shared/{0}.cshtml"
            };


            MasterLocationFormats = new[]
            {
                "~/Themes/" + themeName + "/Views/{1}/{0}.cshtml",
                "~/Themes/" + themeName + "/Views/Shared/{0}.cshtml"
            };


            PartialViewLocationFormats = new[]
            {
                "~/Themes/" + themeName + "/Views/{1}/{0}.cshtml",
                "~/Themes/" + themeName + "/Views/Shared/{0}.cshtml"
            };

            FileExtensions = new[] { "cshtml" };
        }
    }
}