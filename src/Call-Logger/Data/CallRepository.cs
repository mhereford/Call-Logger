
using Call_Logger.Data;
using Call_Logger.Models;
using System;
using System.Linq;
using Call_Logger;


namespace Call_Logger.Data
{
    public class CallRepository
    {
        private static Call[] _calls = new Call[]
        {
        };


        public Call[] GetCalls()
        {
            using (var context = new Context())
            {
                return context.Call.ToArray();
            }
        } 


        public Call GetCall(int ID)
        {
            using (var context = new Context())
            {
                _calls = context.Call.ToArray();
            }

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
            int nextAvailableId = context.Calls.Max(c => c.ID) + 1;

            call.ID = nextAvailableId;
            using (var context = new Context())
            {
                context.Call.Add(call);
                context.SaveChanges();
            }
        }

        public void UpdateCall(Call call)
        {

            // Find the index of the entry that we need to update.
            int callIndex = context.Calls.FindIndex(c => c.ID == call.ID);

            if (callIndex == -1)
            {
                throw new Exception(
                    string.Format("Unable to find a call with an ID of {0}", call.ID));
            }

            context.Calls[callIndex] = call;

          }
        
        /// <summary>
        /// Deletes an entry.
        /// </summary>
        /// <param name="id">The ID of the entry to delete.</param>
        public void DeleteCall(int id)
        {
            // Find the index of the entry that we need to delete.
            int callIndex = context.Calls.FindIndex(c => c.ID == id);

            if (callIndex == -1)
            {
                throw new Exception(
                    string.Format("Unable to find a call with an ID of {0}", id));
            }

            context.Calls.RemoveAt(callIndex);
        }
    }
}