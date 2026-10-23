using Microsoft.AspNetCore.Mvc;

namespace Lesson_2.Controllers
{
    // Conventional Routing: URL theo mẫu trong Program.cs
    // /RoutingDemo/Product/5
    public class RoutingDemoController : Controller
    {
        public IActionResult Product(int id)
        {
            ViewBag.Message = $"Conventional Routing: Bạn đang xem sản phẩm có ID = {id}.";
            return View("Index");
        }

        // Attribute Routing: URL được khai báo trực tiếp trên action
        // /route-attribute/product/5
        [Route("route-attribute/product/{id:int}")]
        public IActionResult ProductByAttribute(int id)
        {
            ViewBag.Message = $"Attribute Routing: Bạn đang xem sản phẩm có ID = {id}.";
            return View("Index");
        }
    }
}
