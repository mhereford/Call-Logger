using System.Collections;
using System.Collections.Generic;
using Call_Logger.Models;
using Call_Tracker.Models;

namespace Call_Logger.Data
{
    /// <summary>
    /// Provides an in-memory data store.
    /// 
    /// Note: The code in this class is not to be considered a "best practice" 
    /// example of how to do data persistence, but rather as workaround for
    /// not having a database to persist data to.
    /// </summary>
    public static class Data
    {
        public static List<Status> Stati { get; set; }

        /// <summary>
        /// The collection of calls.
        /// </summary>
        public static List<Call> Calls { get; set; }

        /// <summary>
        /// Static constructor used to initialize the data.
        /// </summary>
        static Data()
        {
            InitData();
        }

        private static void InitData()
        {

            var stati = new List<Status>()
            {
                new Status(Status.StatusType.Open),
                new Status(Status.StatusType.Hold),
                new Status(Status.StatusType.Closed)
            };

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
                    Call_Status = "Closed",
                    Registrant_ID = 3000000,
                    Call_Summary = "<p>Requested to be opted out of VNS.</p>",
                    Call_Notes = null
                }
            };

            Stati = stati;
            Calls = calls;
        }
    }
}