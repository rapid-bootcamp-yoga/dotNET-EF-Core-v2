using Microsoft.AspNetCore.Mvc;

namespace dotNetEFCore_v2.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
