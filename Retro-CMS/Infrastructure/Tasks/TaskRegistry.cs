using System.IO;
using Retro_CMS.Infrastructure.Assemblies;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;

namespace Retro_CMS.Infrastructure.Tasks
{
    public class TaskRegistry : Registry
    {
        public TaskRegistry()
        {
            Scan(scan =>
            {
                scan.AssembliesFromApplicationBaseDirectory();
                scan.AddAllTypesOf<IRunAtInit>();
                scan.AddAllTypesOf<IRunOnEachRequest>();
                scan.AddAllTypesOf<IRunOnError>();
                scan.AddAllTypesOf<IRunAfterEachRequest>();
            });
        }
    }
}