using lab12.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab12.Controllers
{
    public class CalcController : Controller
    {
        // manual parsing in single action 
        public IActionResult FormManualParsing()
        {
            CalcViewModel calcViewModel = new CalcViewModel();
            return View(calcViewModel);
        }

        [HttpPost]
        public IActionResult ProcessManualParsing()
        {
            return View();
        }

        // manual parsing in separate actions
        public IActionResult FormManualParsingSeparateActions()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetManualParsingSeparateActions()
        {
            return View();
        }

        public IActionResult ProcessManualParsingSeparateActions()
        {
            return View();
        }

        // model binding (parameters)
        public IActionResult ModelBindingParameters()
        {
            return View();
        }

        // model binding (separate model)
        public IActionResult ModelBindingSeparate()
        {
            return View();
        }
    }
}
