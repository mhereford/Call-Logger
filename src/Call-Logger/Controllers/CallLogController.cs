using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Call_Logger.Models;

namespace Call_Logger.Controllers
{
    public class CallLogController : Controller
    {
        public ActionResult Detail()
        {
            var call = new Call()
            {
                CallID = 001,
                CustRep = "Greg Sherman",
                CallTS = "2017-02-22",
                CallStatus = "Open",
                SummaryHtml = "<p>VIS password reset.  Where's my money???</p>",
                TopicFlags = new TopicFlag[]
                {
                    new TopicFlag() { Topic = "Restitution", TopicSelected = true },
                    new TopicFlag() { Topic = "Opt-Out", TopicSelected = false },
                    new TopicFlag() { Topic = "Cancel Phone Call", TopicSelected = false }
                }
            };

          return View(call);
        }
    }
}