using System.Collections.Generic;
using Call_Logger.Models;
using System.Web.Mvc;

namespace Call_Logger.Data
{
    public static class context
    {
         /// <summary>
        /// The collection of calls.
        /// </summary>
        public static List<Call> Calls { get; set; }

        /// <summary>
        /// Static constructor used to initialize the data.
        /// </summary>
        static context()
        {
            InitData();
        }

        private static void InitData()
        {
            
                
            var calls = new List<Call>()
            {
                new Call()
                {
                    ID = 001,
                    Call_Rep = "Greg Sherman",
                    Call_Status = "Open",
                    Registrant_ID = 200001,
                    Call_Summary = "<p>VIS password reset.  Where's my money???</p>",
                    Call_Notes = null
                },

                new Call()
                {
                   ID = 002,
                    Call_Rep = "Greg Sherman",
                    Call_Status = "Closed",
                    Registrant_ID = 200200,
                    Call_Summary = "<p>Updated address and phone number.</p>",
                    Call_Notes = null
                },


                new Call()
                {
                    ID = 003,
                    Call_Rep = "Chris Ashby",
                    Call_Status = "Open",
                    Registrant_ID = 3000000,
                    Call_Summary = "<p>Requested to be opted out of VNS.</p>",
                    Call_Notes = null
                }
            };

           Calls = calls;
        }
    }
}