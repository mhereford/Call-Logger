using System.Data.Entity;
using Call_Logger.Models;

namespace Call_Logger
{
    public class Context : DbContext
    {
        public Context()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
        }

        public DbSet<Call> Call { get; set; }
    }
}


//*   Instantiate the Context
//*         using (var context = new Context())  
//*            { 
//*                   context.Calls.Add(new Call()
//*                   {
//*                         ID = 1,
//*                         Call_TS = DateTime.Today,
//*                         Call_Rep = "Greg Sherman",
//*                         Call_Status = "Open",
//*                         Call_Summary = "VIS Reset"
//*                    });
//*                    context.SaveChanges();
//*              }   
