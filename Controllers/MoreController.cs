using Microsoft.AspNetCore.Mvc;

namespace CA_Project.Controllers
{
    public class MoreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
