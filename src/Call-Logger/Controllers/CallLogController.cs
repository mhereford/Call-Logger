﻿using System;
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
            return Content("This is the Call Logger Controller.");
        }
    }
}