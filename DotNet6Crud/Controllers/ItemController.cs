using DotNet6Crud.Data;
using DotNet6Crud.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNet6Crud.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ItemController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Item> objList = _db.Items;

            return View(objList);
        }
    }
}
