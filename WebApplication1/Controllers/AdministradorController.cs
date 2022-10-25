using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("/")]
    public class AdministradorController : Controller
    {
        public IActionResult Index()
        {
            return View("Home");
        }
    }
}
