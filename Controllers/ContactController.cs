using Microsoft.AspNetCore.Mvc;

namespace CA_Project.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
