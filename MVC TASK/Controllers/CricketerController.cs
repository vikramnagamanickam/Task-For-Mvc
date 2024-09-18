using DataAccessLayer;
using DataAccessLayer.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_TASK.Controllers
{
    public class CricketerController : Controller
    {
        ICricketerRepository con = null;
        public CricketerController(ICricketerRepository Cric)
        {
            con = Cric;
        }

        // GET: CricketerController1
        public ActionResult List()
        {
            var Result = con.GetAllDetail(); 
            return View("List",Result);
        }

        // GET: CricketerController1/Details/5
        public ActionResult Details(int id)
        {
            var result = con.GetplayerbyId(id);
            return View("Details", result);
        }

        // GET: CricketerController1/Create
        public ActionResult Create()
        {
            return View("Add", new CricketerDetails());
        }

        // POST: CricketerController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CricketerDetails cric)
        {
            try
            {
                con.InsertDetail(cric);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }

        // GET: CricketerController1/Edit/5
        public ActionResult Edit(long CricketersID)
        {
            CricketerDetails Edit = con.GetplayerbyId(CricketersID);
            return View("Edit", Edit);
        }

        // POST: CricketerController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CricketerDetails cric)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = con.GetplayerbyId(cric.CricketersID);
                    if (result != null)
                    {
                        ModelState.AddModelError("", "Username Already Exists");
                        return View("Add", cric);
                    }
                    con.UpdateDetail(cric);
                    return RedirectToAction(nameof(List));

                }
                else
                {
                    return View("Add", cric);
                }


            }
            
               
            
            catch
            {
                return View();
            }
        }

        // GET: CricketerController1/Delete/5
        public ActionResult Delete(int id)
        {
            var DeleteValue = con.GetplayerbyId(id);
            return View("Delete", DeleteValue);
        }

        // POST: CricketerController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long CricketersID)
        {
            try
            {
                con.DeleteDetail(CricketersID);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }
    }
}
