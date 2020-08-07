using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pudja.VeichleDB.Models;
using Pudja.VeichleDB.Services;

namespace Pudja.VeichleDB.Controllers
{
    public class VMakeController : Controller
    {

        #region Dependancy
        private readonly IVMakeServices _db;

        public VMakeController(IVMakeServices db)
        {
            _db = db;
        }
        #endregion

        #region Index
        public async Task<IActionResult> Index()
        {
            var items = await _db.GetIncompleteItemsAsync();

            var model = new VMakeWievs()
            {
                MakeItems = items
            };
            return View(model);
        }
        #endregion

        #region Upsert
        //Needs : methods for saving data to DB and for editing
        public IActionResult Upsert()
        {

            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Upsert(VMake newItem)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            var scs = await _db.AddItemAsync(newItem);
            if (!scs)
            {
                return BadRequest("Item was not added");
            }
            return RedirectToAction("Index");
        }
        #endregion
    }
}
