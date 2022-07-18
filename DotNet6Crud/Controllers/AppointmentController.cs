using Microsoft.AspNetCore.Mvc;

namespace DotNet6Crud.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
