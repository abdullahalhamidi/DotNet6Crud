using DotNet6Crud.Data;
using DotNet6Crud.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNet6Crud.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AppointmentController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            //IEnumerable<Appointment> objList = _db.Appointments;

            //return View(objList);
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Appointment obj)
        {
            _db.Appointments.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
