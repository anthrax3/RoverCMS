using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Default.Controllers
{
    public class MeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
