using Microsoft.AspNetCore.Mvc;

namespace Lesson_2.ViewComponents
{
    public class WelcomeViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string name)
        {
            return View("Default", name);
        }
    }
}
