using Microsoft.AspNetCore.Mvc;

namespace Clinica.Controllers
{
    public class ClinicaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
