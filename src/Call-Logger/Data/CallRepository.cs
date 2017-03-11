using Call_Logger.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Call_Logger.Data
{
    public class CallRepository
    {
        private static Call[] _calls = new Call[]
        {
        };
            

        public Call[] GetCalls()
        {
            return _calls;
        }


        public Call GetCall(int ID)
        {
            Call callToReturn = null;

            foreach (var call in _calls)
            {
                if (call.ID == ID)
                {
                    callToReturn = call;
                    break;
                }

            }
            return callToReturn;
        }

        public void AddCall(Call call)
        {
            // Get the next available call ID.
            int nextAvailableId = Data.Calls
                .Max(c => c.ID) + 1;

            call.ID = nextAvailableId;

            Data.Calls.Add(call);
        }
    }
}