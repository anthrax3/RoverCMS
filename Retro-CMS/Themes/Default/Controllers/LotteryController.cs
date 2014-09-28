using System.Web.Mvc;
using Default.Models.Lottery;

namespace Default.Controllers
{
    public class LotteryController : Controller
    {
        public ActionResult Index()
        {
            return View(new LotteryModel());
        }
    }
}