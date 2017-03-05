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
        private CallLogRepository _callLogRepository = null;

        public CallLogController()
        {
            _callLogRepository = new CallLogRepository();
        }

        public ActionResult Index()
        {
            var calls = _callLogRepository.GetCalls();
            return View(calls);
        }

        public ActionResult Add()
        {
              return View();
        }

        [HttpPost]
        public ActionResult Add(int? callID, string custRep, DateTime? callTS, string callStatus, int? registrantID, string summaryHtml, string callNotes)
        {

            ViewBag.CallID = ModelState["CallID"].Value.AttemptedValue;
            ViewBag.CustRep = ModelState["CustRep"].Value.AttemptedValue;
            ViewBag.CallTS = ModelState["CallTS"].Value.AttemptedValue;
            ViewBag.CallStatus = ModelState["CallStatus"].Value.AttemptedValue;
            ViewBag.RegistrantID = ModelState["RegistrantID"].Value.AttemptedValue;
            ViewBag.SummaryHtml = ModelState["SummaryHtml"].Value.AttemptedValue;
            ViewBag.CallNotes = ModelState["CallNotes"].Value.AttemptedValue;

            return View();
        }


        public ActionResult Detail(int? ID)
        {
            if (ID == null)
            {
                return HttpNotFound();
            }

            var call = _callLogRepository.GetCall((int)ID);
            return View(call);
        }
    }
}