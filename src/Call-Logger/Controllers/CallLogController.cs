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
        public ActionResult Add(int callID, string custRep, string callTS, string callStatus, int registrantID, string summaryHtml, string [] topicFlag, string callNotes)
        {
            ViewBag.CallID = callID;
            ViewBag.CustRep = custRep;
            ViewBag.CallTS = callTS;
            ViewBag.CallStatus = callStatus;
            ViewBag.RegistrantID = registrantID;
            ViewBag.SummaryHtml = summaryHtml;
            ViewBag.TopicFlag = topicFlag;
            ViewBag.CallNotes = callNotes;

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