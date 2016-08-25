using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Auditor.ViewModels.WifiCheck;
using Auditor.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Auditor.Controllers
{
    public class WifiCheckController : Controller
    {
        // GET: /WiFiCheck/
        public IActionResult Index()
        {
            var model = new List<WifiCheckListVM>();
            return View(model);
        }

        // GET: /WiFiCheck/Create
        [HttpGet]
        public IActionResult Create()
        {
            var model = new WifiCheckFormVM();
            model.RegionList = new List<SelectListItem> { new SelectListItem { Value = "71", Text = "Тула" } };
            model.AuditorUserList = new List<SelectListItem> { new SelectListItem { Value = "1", Text = "Павлов" } };
            model.CheckDate = DateTime.Now.Date;
            return View(model);
        }

        // POST: /WiFiCheck/Create
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Create(WifiCheckFormVM model)
        {
            if (ModelState.IsValid)
            {
                var entity = new WifiCheck
                {
                    Address = model.Address,
                    Provider = model.Provider,
                    TerritoryId = model.TerritoryId,
                    UserId = model.AuditorUserId,
                    CheckDate = model.CheckDate,
                    ViolationsCount = model.ViolationsCount,
                    TaskTime = model.TaskTime,
                    Note = model.Note,
                    CreatedAt = DateTime.Now
                };
                return RedirectToAction("Index", "WiFiCheck");
            }
            return View(model);
        }
    }
}
