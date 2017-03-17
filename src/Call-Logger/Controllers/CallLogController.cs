using System;
using System.Web.Mvc;
using Call_Logger.Models;
using Call_Logger.Data;
using System.Net;

namespace Call_Logger.Controllers
{
    public class CallLogController : Controller
    {
        private CallRepository _callRepository = null;

        public CallLogController()
        {
            _callRepository = new CallRepository();
        }

        public ActionResult Index()
        {
            var calls = _callRepository.GetCalls();
            return View(calls);
        }

        public ActionResult Add()
        {
            var call = new Call()
            {
                Call_TS = DateTime.Today,
            };

            SetupStatiSelectList();

            return View(call);
        }

        

        [HttpPost]
        public ActionResult Add(Call call)
        {
            ValidateCall(call);

            if (ModelState.IsValid)
            {
                _callRepository.AddCall(call);
                TempData["Message"] = "Your call was successfully logged!";
                return RedirectToAction("Index");
            }
            
            SetupStatiSelectList();

            return View(call);
        }

      

        public ActionResult Edit(int? id)
        {
          if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            //TODO Get the requested entry from the repository
            Call call = _callRepository.GetCall((int)id);

            if (call == null)
            {
             return HttpNotFound();
            }
            //Return a status of NOt found
            //TODO Pass the entry to the view
            SetupStatiSelectList();

            return View(call);
        }

        [HttpPost]
        public ActionResult Edit(Call call)
        {
            //validate call
            ValidateCall(call);
            
            // if valid
            // update call in repository
            // redirext user to list page
            if (ModelState.IsValid)
            {
                _callRepository.UpdateCall(call);
                TempData["Message"] = "Your call was successfully updated!";
                return RedirectToAction("Index");
            }

            SetupStatiSelectList();
            //populate the select list

            return View(call);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            //Retrieve cal for the provided ID
            Call call = _callRepository.GetCall((int)id);


            //Return "NOT FOUND" if an entry wasn't found.
            if (call == null)
            {
                return HttpNotFound();
            }

            return View(call);
        }

        
        [HttpPost]
        public ActionResult Delete(int id)
        {
            _callRepository.DeleteCall(id);

            TempData["Message"] = "Your call was successfully deleted!";
            //redirect to list page
            return RedirectToAction("Index");
        }

        public ActionResult Detail(int? ID)
        {
            if (ID == null)
            {
                return HttpNotFound();
            }

            var call = _callRepository.GetCall((int)ID);
            return View(call);
        }


        private void ValidateCall(Call call)
        {
            if (ModelState.IsValidField("Registrant_ID") == false && call.Registrant_ID <= 0)
            {
                ModelState.AddModelError("Registrant_ID", "The Registrant ID field is required.");
            }
        }


        private void SetupStatiSelectList()
        {
            ViewBag.StatiSelectListItems = new SelectList(
                            Data.context.Stati, "Id", "Name");
        }
    }
}