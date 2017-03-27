using System.Data.Entity;
using Call_Logger.Models;
using System;


//SEED DATA FOR CALL LOGGER
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
               Call_Notes = "Registrant wanted to check status of their restution, but forgot password."
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
                Call_Notes = "Registrant moved and wanted to update contact information.  New phone number and home address added."
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
                Call_Notes = "Registrant no longer wants to recieve notifictions from VNS.  Opted-Out as Contact Choice."
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
                Call_Notes = "Registrant forgot VIS password.  Password reset."
            };
            context.Call.Add(call4);

            var call5 = new Call()
            {
                ID = 5,
                Call_TS = DateTime.Now,
                Call_Rep = "Luz Acosta",
                Call_Status = "Open",
                Registrant_ID = 400001,
                Call_Summary = "VIS password reset and restitution question.",
                Call_Notes = "Registrant wanted to check status of their restution, but forgot password."
            };
            context.Call.Add(call5);

            var call6 = new Call()
            {
                ID = 6,
                Call_TS = DateTime.Now,
                Call_Rep = "Maren Boehm",
                Call_Status = "Closed",
                Registrant_ID = 400200,
                Call_Summary = "Updated address and phone number.",
                Call_Notes = "Registrant moved and wanted to update contact information.  New phone number and home address added."
            };
            context.Call.Add(call6);

            var call7 = new Call()
            {
                ID = 7,
                Call_TS = DateTime.Now,
                Call_Rep = "Chris Ashby",
                Call_Status = "Hold",
                Registrant_ID = 3000101,
                Call_Summary = "Requested to be opted out of VNS.",
                Call_Notes = "Registrant no longer wants to recieve notifictions from VNS.  Opted-Out as Contact Choice."
            };
            context.Call.Add(call7);

            var call8 = new Call()
            {
                ID = 8,
                Call_TS = DateTime.Now,
                Call_Rep = "Luz Acosta",
                Call_Status = "Open",
                Registrant_ID = 200001,
                Call_Summary = "VIS password reset.",
                Call_Notes = "Registrant forgot VIS password.  Password reset."
            };
            context.Call.Add(call8);

            var call9 = new Call()
            {
                ID = 9,
                Call_TS = DateTime.Now,
                Call_Rep = "Greg Sherman",
                Call_Status = "Open",
                Registrant_ID = 200001,
                Call_Summary = "VIS password reset and restitution question.",
                Call_Notes = "Registrant wanted to check status of their restution, but forgot password."
            };
            context.Call.Add(call9);

            var call10 = new Call()
            {
                ID = 10,
                Call_TS = DateTime.Now,
                Call_Rep = "Luz Acosta",
                Call_Status = "Closed",
                Registrant_ID = 200200,
                Call_Summary = "Updated address and phone number.",
                Call_Notes = "Registrant moved and wanted to update contact information.  New phone number and home address added."
            };
            context.Call.Add(call10);

            var call11 = new Call()
            {
                ID = 11,
                Call_TS = DateTime.Now,
                Call_Rep = "Chris Ashby",
                Call_Status = "Open",
                Registrant_ID = 3000000,
                Call_Summary = "Requested to be opted out of VNS.",
                Call_Notes = "Registrant no longer wants to recieve notifictions from VNS.  Opted-Out as Contact Choice."
            };
            context.Call.Add(call11);

            var call12 = new Call()
            {
                ID = 12,
                Call_TS = DateTime.Now,
                Call_Rep = "Luz Acosta",
                Call_Status = "Open",
                Registrant_ID = 200001,
                Call_Summary = "VIS password reset.",
                Call_Notes = "Registrant forgot VIS password.  Password reset."
            };
            context.Call.Add(call12);

            context.SaveChanges();
        }
    }
}