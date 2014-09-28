using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Dependencies;
using Microsoft.Practices.ServiceLocation;
using StructureMap;

namespace Retro_CMS.Infrastructure.Tasks
{
    public class StructureMapDependencyResolver : IDependencyResolver, IServiceLocator
    {
        private readonly Func<IContainer> _containerFactory;

        public StructureMapDependencyResolver(Func<IContainer> containerFactory)
        {
            _containerFactory = containerFactory;
        }

        public void Dispose()
        {
           
        }

        public object GetService(Type serviceType)
        {
            if (serviceType != null)
            {
                var container = _containerFactory();

                return serviceType.IsAbstract || serviceType.IsInterface
                    ? container.TryGetInstance(serviceType)
                    : container.GetInstance(serviceType);
            }

            return null;
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return ObjectFactory.GetAllInstances(serviceType).Cast<object>();
        }

        public IDependencyScope BeginScope()
        {
            return this;
        }

        public object GetInstance(Type serviceType)
        {
            return GetService(serviceType);
        }

        public object GetInstance(Type serviceType, string key)
        {
            return GetService(serviceType);
        }

        public IEnumerable<object> GetAllInstances(Type serviceType)
        {
            return GetServices(serviceType);
        }

        TService IServiceLocator.GetInstance<TService>()
        {
            return (TService)GetInstance(typeof(TService), null);
        }

        public TService GetInstance<TService>(string key)
        {
            return (TService)GetInstance(typeof(TService), key);
        }

        IEnumerable<TService> IServiceLocator.GetAllInstances<TService>()
        {
            return GetAllInstances(typeof(TService)).Select(item => (TService)item);
        }

        public T GetInstance<T>() where T : class
        {
            return ObjectFactory.GetInstance<T>();
        }

        public ICollection<T> GetAllInstances<T>() where T : class
        {
            return (ICollection<T>) ObjectFactory.GetAllInstances<T>();
        }
    }
}