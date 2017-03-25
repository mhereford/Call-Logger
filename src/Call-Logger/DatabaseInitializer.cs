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
                ID = 1,
                Call_TS = DateTime.Now,
                Call_Rep = "Greg Sherman",
                Call_Status = "Open",
                Registrant_ID = 200001,
                Call_Summary = "VIS password reset and restitution question.",
               Notes = "Registrant wanted to check status of their restution, but forgot password."
           };
            context.Call.Add(call1);

            var call2 = new Call()
            {
                ID = 2,
                Call_TS = DateTime.Now,
                Call_Rep = "Luz Acosta",
                Call_Status = "Closed",
                Registrant_ID = 200200,
                Call_Summary = "Updated address and phone number.",
                Notes = "Registrant moved and wanted to update contact information.  New phone number and home address added."
            };
            context.Call.Add(call2);

            var call3 = new Call()
            {
                ID = 3,
                Call_TS = DateTime.Now,
                Call_Rep = "Chris Ashby",
                Call_Status = "Open",
                Registrant_ID = 3000000,
                Call_Summary = "Requested to be opted out of VNS.",
                Notes = "Registrant no longer wants to recieve notifictions from VNS.  Opted-Out as Contact Choice."
            };
            context.Call.Add(call3);

            var call4 = new Call()
            {
                ID = 4,
                Call_TS = DateTime.Now,
                Call_Rep = "Luz Acosta",
                Call_Status = "Open",
                Registrant_ID = 200001,
                Call_Summary = "VIS password reset.",
                Notes = "Registrant forgot VIS password.  Password reset."
            };
            context.Call.Add(call4);

            context.SaveChanges();
        }
    }
}