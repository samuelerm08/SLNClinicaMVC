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

            //var medicos = context.Medicos.ToList();

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

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var medico = context.Medicos.Find(id);

            if (medico == null) return NotFound();

            else return View("Delete", medico);

        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {

            var medico = context.Medicos.Find(id);

            if (medico == null)
            {

                return NotFound();

            }

            context.Medicos.Remove(medico);
            context.SaveChanges();

            return RedirectToAction("Index");
        }



    }


}
