using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;
using Retro_CMS.Infrastructure.Assemblies;
using Retro_CMS.Models.ControllerFactory;

namespace Retro_CMS.Infrastructure.Controller
{
    public class CustomControllerFactory : DefaultControllerFactory
    {

        private System.Web.Mvc.Controller GetInstance(string controllerName)
        {
            return ThemeAssemblyManager.Manager.Controllers.Where(x => x.ControllerName.Equals(controllerName, StringComparison.CurrentCultureIgnoreCase)).Select(x => x.Controller).FirstOrDefault();
        }

        public override IController CreateController(RequestContext requestContext, string controllerName)
        {
            // Get controllermodel
            var controller = GetInstance(controllerName);

            // Return the controller if we found any with the given name
            if (controller != null)
            {
                var controllerType = controller.GetType();

                return (IController) Activator.CreateInstance(controllerType);
            }

            // Controller not found - 404 error
            HttpContext.Current.Response.StatusCode = 404;

            return null;
        }
    }
}
