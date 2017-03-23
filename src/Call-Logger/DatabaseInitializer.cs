using System.Collections.Generic;
using System.Data.Entity;
using Call_Logger.Models;
using System;

namespace Call_Logger
{
    internal class DatabaseInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            var call1 = new Call()
            {
                ID = 100,
                Call_TS = DateTime.Now,
                Call_Rep = "Greg Sherman",
                Call_Status = "Open",
                Registrant_ID = 200001,
                Call_Summary = "VIS password reset and restitution question.",
                Call_Notes = "Requested password reset and how to collect restitution."
            };

            var call2 = new Call()
            {
                ID = 101,
                Call_TS = DateTime.Now,
                Call_Rep = "Luz Acosta",
                Call_Status = "Closed",
                Registrant_ID = 200200,
                Call_Summary = "Updated address and phone number.",
                Call_Notes = "Updated contact information at registrants request."
            };

            var call3 = new Call()
            {
                ID = 102,
                Call_TS = DateTime.Now,
                Call_Rep = "Chris Ashby",
                Call_Status = "Open",
                Registrant_ID = 3000000,
                Call_Summary = "Requested to be opted out of VNS.",
                Call_Notes = null
            };

            var call4 = new Call()
            {
                ID = 103,
                Call_TS = DateTime.Now,
                Call_Rep = "Luz Acosta",
                Call_Status = "Open",
                Registrant_ID = 200001,
                Call_Summary = "VIS password reset.",
                Call_Notes = "Registrant forgot password for VIS."
            };
            context.Call.Add(call1);
            context.Call.Add(call2);
            context.Call.Add(call3);
            context.Call.Add(call4);

            context.SaveChanges();
        }
    }
}