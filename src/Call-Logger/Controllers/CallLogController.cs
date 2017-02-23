using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Call_Logger.Controllers
{
    public class CallLogController : Controller
    {
        public ActionResult Detail()
        {
            ViewBag.CallID = 001;
            ViewBag.CustRep = "Greg Sherman";
            ViewBag.CallTS = "02/22/2017";
            ViewBag.RegistrantID = 100001;
            ViewBag.CallStatus = "Open";
            ViewBag.Summary = "<p>VIS password reset.  Where's my money???</p>";
            ViewBag.TopicFlags = new string[]
                {
                    "Restitution: YES",
                    "Opt-Out: NO",
                    "Cancel Phone Call: NO"
                };

            return View();
        }
    }
}