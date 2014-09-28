using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using Retro_CMS.Models.ControllerFactory;

namespace Retro_CMS.Infrastructure.Assemblies
{
    public class ThemeAssemblyManager
    {
        #region Private Properties

        private static readonly Lazy<ThemeAssemblyManager> LazyAssembly = new Lazy<ThemeAssemblyManager>(() => new ThemeAssemblyManager());

        #endregion

        #region Public properties

        public static ThemeAssemblyManager Manager
        {
            get { return LazyAssembly.Value; }
        }

        public string ThemePath
        {
            get { return Path.Combine(HttpContext.Current.Server.MapPath("~/Themes"), "Default"); }
        }

        public IEnumerable<ControllerModel> Controllers { get; private set; }

        public IEnumerable<Assembly> Assemblies
        {
            get { return AppDomain.CurrentDomain.GetAssemblies(); }
        }

        #endregion

        #region Private Methods
        /// <summary>
        /// Initialize assemblymanager
        /// </summary>
        private ThemeAssemblyManager()
        {
            // Load controllers
            Controllers = LoadControllers();
        }

        private IEnumerable<ControllerModel> LoadControllers()
        {
            // Initialize a collection of controllermodels
            var arrayTempControllers = new Collection<ControllerModel>();

            // For every assembly in this domain
            foreach (var assembly in Assemblies)
            {
                // Foreach type in this assembly
                foreach (var exportedType in assembly.GetExportedTypes().Where(type => !type.IsAbstract && type.BaseType != null && type.BaseType == typeof(System.Web.Mvc.Controller)))
                {
                    //  Controller name
                    string controllerName = exportedType.Name.Replace("Controller", "");

                    // Check if this controller hasn't been added yet
                    if (arrayTempControllers.All(x => !x.ControllerName.Equals(controllerName)))
                    {
                        // Create the instance and add the controller to the list
                        arrayTempControllers.Add(new ControllerModel
                        {
                            ControllerName = controllerName,
                            Controller = (System.Web.Mvc.Controller)Activator.CreateInstance(exportedType)
                        });
                    }
                }
            }
            return arrayTempControllers;
        }
        #endregion
    }
}