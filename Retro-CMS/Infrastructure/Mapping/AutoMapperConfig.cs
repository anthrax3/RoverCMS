using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Retro_CMS.Infrastructure.Assemblies;

namespace Retro_CMS.Infrastructure.Mapping
{
    public class AutoMapperConfig
    {
        public static void LoadDefaultMappings()
        {
            foreach (var assembly in ThemeAssemblyManager.Manager.Assemblies)
            {
                foreach (var type in assembly.GetTypes().Where(type => !type.IsAbstract && !type.IsInterface))
                {
                    foreach (var typeInterface in type.GetInterfaces().Where(iface => iface.IsGenericType && iface.GetGenericTypeDefinition() == typeof(IMapFrom<>)))
                    {
                        var source = typeInterface.GetGenericArguments()[0];
                        var destination = type;
                        Mapper.CreateMap(source, destination);
                    }
                }
            }
        }
    }
}