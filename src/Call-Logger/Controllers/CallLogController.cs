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
        public ActionResult Detail()
        {
            return View(call);
        }
    }
}