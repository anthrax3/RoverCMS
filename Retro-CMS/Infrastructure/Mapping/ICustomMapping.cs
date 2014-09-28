using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Retro_CMS.Infrastructure.Mapping
{
    public interface ICustomMapping
    {
        void CreateMappings(IConfiguration configuration);
    }
}
