using ExpenseTrackerProject.Database;
using ExpenseTrackerProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTrackerProject.Controllers
{
    public class ItemController : Controller
    {
        private readonly ExpenseTrackerDbContext _db;

        public ItemController(ExpenseTrackerDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Item> objList = _db.Items;
            return View(objList);
        }

        //Get Create
        public IActionResult Create()
        {
            return View();
        }


        //POST Create 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Item obj)
        {
            _db.Items.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
