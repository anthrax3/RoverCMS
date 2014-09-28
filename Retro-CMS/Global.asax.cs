using System;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using Retro_CMS;
using Retro_CMS.Infrastructure.Assemblies;
using Retro_CMS.Infrastructure.Controller;
using Retro_CMS.Infrastructure.Mapping;
using Retro_CMS.Infrastructure.Tasks;
using Retro_CMS.Infrastructure.View;
using StructureMap;

//[assembly: PreApplicationStartMethod(typeof(AssemblyRegister), "RegisterThemeDlls")]
namespace Retro_CMS
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public IContainer Container
        {
            get { return (IContainer)HttpContext.Current.Items["_container"]; }
            set { HttpContext.Current.Items["_container"] = value; }
        }

        protected void Application_Start()
        {
            // Copy theme dlls
            AssemblyRegister.RegisterThemeDlls();

            // Set mappings
            AutoMapperConfig.LoadDefaultMappings();

            // Register areas
            AreaRegistration.RegisterAllAreas();

           // RouteConfig.RegisterRoutes(RouteTable.Routes);

            // Controller factory
           ControllerBuilder.Current.SetControllerFactory(new CustomControllerFactory());

            // Viewengine
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new CustomViewEngine());

            // Dependency resolver
           // DependencyResolver.SetResolver(new StructureMapDependencyResolver(() => Container ?? ObjectFactory.Container));

            // Scan registry
            //AddRegistries();

            // Run all classes that inherit from IRunAtInit
           // RunOnInitClasses();

            // Add routes
            AddRoutes();

            // Add bundles
            AddBundles();
        }

        private void AddBundles()
        {
            foreach (var assembly in ThemeAssemblyManager.Manager.Assemblies)
            {
                foreach (var type in assembly.GetExportedTypes())
                {
                    if (type.Name.Equals("BundleConfig"))
                    {
                        Activator.CreateInstance(type);
                        return;
                    }
                }
            }
        }

        private void AddRoutes()
        {
            // Get route
            //var routeType = (from assemblies in ThemeAssemblyManager.Manager.ArrayAssemblies
            //    select assemblies.ExportedTypes.Where(x => x.Namespace != null && (x.Name == "RouteConfig" && x.Namespace.EndsWith("Startup"))).ToList()).ToList();

            foreach (var assembly in ThemeAssemblyManager.Manager.Assemblies)
            {
                foreach (var type in assembly.GetExportedTypes())
                {
                    if (type.Name.Equals("RouteConfig"))
                    {
                        Activator.CreateInstance(type);
                        return;
                    }
                }
            }
        }

        private void AddRegistries()
        {
            ObjectFactory.Configure(cfg =>
            {
                cfg.AddRegistry(new StandardRegistry());
                cfg.AddRegistry(new TaskRegistry());
            });
        }

        private void RunOnInitClasses()
        {
            using (var container = ObjectFactory.Container.GetNestedContainer())
            {
                foreach (var task in container.GetAllInstances<IRunAtInit>())
                {
                    task.Execute();
                }
            }
        }

        //public void Application_BeginRequest()
        //{
        //    Container = ObjectFactory.Container.GetNestedContainer();

        //    foreach (var task in Container.GetAllInstances<IRunOnEachRequest>())
        //    {
        //        task.Execute();
        //    }
        //}

        //public void Application_Error()
        //{
        //    foreach (var task in Container.GetAllInstances<IRunOnError>())
        //    {
        //        task.Execute();
        //    }
        //}

        //public void Application_EndRequest()
        //{
        //    Container.Dispose();
        //}
    }
}