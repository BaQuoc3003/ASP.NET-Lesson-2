using Microsoft.AspNetCore.Mvc;

namespace Lesson_2.Controllers
{
    public class ViewDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
