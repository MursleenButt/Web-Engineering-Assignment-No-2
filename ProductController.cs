using Microsoft.AspNetCore.Mvc;

namespace KarigarBotique.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
