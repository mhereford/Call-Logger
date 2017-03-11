using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Call_Logger.Models;
using Call_Logger.Data;

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

            ViewBag.StatiSelectListItems = new SelectList(
                Data.Data.Stati, "Id", "Name");

            return View(call);
        }

        [HttpPost]
        public ActionResult Add(Call call)
        {
            if (ModelState.IsValid)
            {
                _callRepository.AddCall(call);
            }

            ViewBag.StatiSelectListItems = new SelectList(
                Data.Data.Stati, "Id", "Name");

            return View(call);
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
    }
}