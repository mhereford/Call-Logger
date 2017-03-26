using System.Collections.Generic;
using Call_Logger.Models;

namespace Call_Logger.Data
{
    public static class context
    {
        // <summary>
        // The collection of calls.
        // </summary>
        public static List<Call> Calls { get; set; }

        // <summary>
        // Static constructor used to initialize the data.
        // </summary>
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
                    ID = 1,
                    Call_Rep = "Greg Sherman",
                    Call_Status = "Open",
                    Registrant_ID = 200001,
                    Call_Summary = "<p>VIS password reset.  Where's my money???</p>",
                    Call_Notes = null
                }
            };
            Calls = calls;
        }

    }
    
}