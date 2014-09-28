using StructureMap.Configuration.DSL;
using StructureMap.Graph;

namespace Retro_CMS.Infrastructure.Tasks
{
    public class StandardRegistry : Registry
    {
        public StandardRegistry()
        {
            Scan(scan =>
            {
                scan.TheCallingAssembly();
                scan.WithDefaultConventions();
            });
        }
    }
}