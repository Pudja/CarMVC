using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pudja.VeichleDB.Models;
using Pudja.VeichleDB.Services;

namespace Pudja.VeichleDB.Controllers
{
    public class VModelController : Controller
    {

        #region Dependancy
        private readonly IVModelServices _db;

        public VModelController(IVModelServices db)
        {
            _db = db;
        }
        #endregion

        #region Index
        public async Task<IActionResult> Index()
        {
            var items = await _db.GetIncompleteItemsAsync();

            var model = new VModelWievs()
            {
                ModelItems = items
            };

            return View(model);
        }
        #endregion

        #region Upsert
        public IActionResult Upsert()
        {

            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Upsert(VModel newItem)
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
