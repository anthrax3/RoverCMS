using System.Web.Mvc;
using AutoMapper;
using BotDetect.Web.UI.Mvc;
using Default.Models.Register;

namespace Default.Controllers
{
    public class RegisterController : Controller
    {
        public ActionResult Index()
        {
            return View(new StepOneModel());
        }

        [HttpPost]
        public ActionResult Index(StepOneModel stepOneModel)
        {
            if (ModelState.IsValid)
            {
                var model = Mapper.Map<StepTwoModel>(stepOneModel);

                return View("Step2", model);
            }

            return View(stepOneModel);
        }

        public ActionResult Step2(StepOneModel stepOneModel)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Step2(StepTwoModel stepTwoModel)
        {
            if (ModelState.IsValid)
            {
                return View("Step3", stepTwoModel);
            }

            return View(stepTwoModel);
        }

        public ActionResult Step3()
        {
            return View("Step3");
        }

        [HttpPost]
        [CaptchaValidation("CaptchaCode", "Captcha", "The captcha code is incorrect")]
        public ActionResult Step3(StepTwoModel stepTwoModel)
        {
            if (ModelState.IsValid)
            {
                // Register
            }

            return View("Step3", stepTwoModel);
        }
    }
}
