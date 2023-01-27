using Clinica.Data;
using Clinica.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Runtime.InteropServices;

namespace Clinica.Controllers
{
    public class ClinicaController : Controller
    {
        private readonly DbClinicaContext context;

        public ClinicaController(DbClinicaContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            Medico medico = new Medico();

            return View("Create", medico);
        }

        [HttpPost]
        public ActionResult Create(Medico medico)
        {
            if (ModelState.IsValid)
            {
                context.Medicos.Add(medico);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(medico);
        }
    }
}
