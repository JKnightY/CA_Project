using Microsoft.AspNetCore.Mvc;

namespace CA_Project.Controllers
{
    public class ShoppingCartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
