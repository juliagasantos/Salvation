using Microsoft.AspNetCore.Mvc;

namespace Salvation.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
