using Call_Logger.Models;
using System.Linq;
using System.Data.Entity;

//DATA REPOSITORY FOR CALL CONTROLLER

namespace Call_Logger.Data
{

    public class CallRepository
    {
       private static Call[] _calls = new Call[]
        {
        };

        //Purpose:  Return all calls in the form of an array.
        public Call[] GetCalls()
        {
            using (var context = new Context())
            {
                return context.Call.ToArray();
            }
        }

        // Purpose:  Return all calls for a specific status.  
        //Note:  Not implemented in lieu of Jquery Dynamic filter.
        public Call[] GetCallsByStatus(string status)
        {
            using (var context = new Context())
            {
                var callStatus = status;
                if(callStatus == "All")
                {
                    return context.Call.ToArray();
                }
                else if(callStatus == "Open")
                {
                    var calls = context.Call
                      .Where(c => c.Call_Status == "Open")
                      .ToArray();
                    return (calls);
                }
                else if (callStatus == "Hold")
                {
                    var calls = context.Call
                      .Where(c => c.Call_Status == "Hold")
                      .ToArray();
                    return (calls);
                }
                else 
                {
                    var calls = context.Call
                      .Where(c => c.Call_Status == "Closed")
                      .ToArray();
                    return (calls);
                }
            }
        }
        //Purpose: Return a call given the CALL.ID.
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

        //Purpose:  Add new call to Database.
        public void AddCall(Call call)
        {            
            // Get the next available call ID.
            int nextAvailableId = context.Calls.Max(c => c.ID) + 1;

            call.ID = nextAvailableId;
            
            using (Context context = GetContext())
            {
                context.Call.Add(call);
                context.SaveChanges();
            }
        }

        // Purpose:  Update Existing Call
        public void UpdateCall(Call call)
        {
            using (Context context =  GetContext())
            {
                context.Call.Attach(call);
                context.Entry(call).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        /// Purpose: Deletes an entry.
        /// <param name="id">The ID of the entry to delete.</param>
        public void DeleteCall(int id)
        {
            using (Context context = GetContext())
            {
                Call call = context.Call.Find(id);
                context.Call.Remove(call);
                context.SaveChanges();
            }
        }
        //Purpose: Return the context for other methods use.
        static Context GetContext()
        {
            var context = new Context();
            return context;
        }
    }
}