using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Retro_CMS.Models.ControllerFactory
{
    public class ControllerModel
    {
        public string ControllerName { get; set; }
        public Controller Controller { get; set; }
    }
}