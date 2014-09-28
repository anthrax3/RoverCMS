using System.Web.Mvc;

namespace Default.Controllers
{
    public class NewsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        } 
    }
}