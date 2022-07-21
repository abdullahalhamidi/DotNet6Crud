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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Item obj)
        {
            _db.Items.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int id = 0)
        {
            if(id == 0) 
            { 
                return View(); 
            } 
            else
            {
                return View(_db.Items.Find(id));
            }
        }

    }
}
