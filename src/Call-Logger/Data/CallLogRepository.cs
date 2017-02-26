using Call_Logger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Call_Logger.Data
{
    public class CallLogRepository
    {
        private static Call[] _calls = new Call[]
        {
            new Call()
            {
                CallID = 001,
                CustRep = "Greg Sherman",
                CallTS = "2017-02-22",
                CallStatus = "Open",
                RegistrantID = 200001,
                SummaryHtml = "<p>VIS password reset.  Where's my money???</p>",
                TopicFlags = new TopicFlag[]
                {
                    new TopicFlag() { Topic = "Restitution", TopicSelected = true },
                    new TopicFlag() { Topic = "Opt-Out", TopicSelected = false },
                    new TopicFlag() { Topic = "Cancel Phone Call", TopicSelected = false }
                }
            },

            new Call()
            {
                CallID = 002,
                CustRep = "Greg Sherman",
                CallTS = "2017-02-22",
                CallStatus = "Closed",
                RegistrantID = 200200,
                SummaryHtml = "<p>Updated address and phone number.</p>",
                TopicFlags = new TopicFlag[]
                {
                    new TopicFlag() { Topic = "Restitution", TopicSelected = false },
                    new TopicFlag() { Topic = "Opt-Out", TopicSelected = false },
                    new TopicFlag() { Topic = "Cancel Phone Call", TopicSelected = false }
                }
            },

            new Call()
            {
                CallID = 003,
                CustRep = "Chris Ashby",
                CallTS = "2017-02-23",
                CallStatus = "Closed",
                RegistrantID = 3000000,
                SummaryHtml = "<p>Requested to be opted out of VNS.</p>",
                TopicFlags = new TopicFlag[]
                {
                    new TopicFlag() { Topic = "Restitution", TopicSelected = false },
                    new TopicFlag() { Topic = "Opt-Out", TopicSelected = true },
                    new TopicFlag() { Topic = "Cancel Phone Call", TopicSelected = false }
                }
            }
        };

        public Call GetCall(int ID)
        {
            Call callToReturn = null;

            foreach (var call in _calls)
            {
                if (call.CallID == ID)
                {
                    callToReturn = call;
                    break;
                }

            }
            return callToReturn;
        }
    }
}