using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Lesson_2.Controllers
{
    public class HelloController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        [Route("What's up")]
        public IActionResult Welcome(string name, int numTimes)
        {
            ViewData["name"] = "Hello" + name;
            ViewBag.numTimes = numTimes;
            ViewData["Message"] = "Good moring pretty girl!";
            return View();
        }
    }
}
