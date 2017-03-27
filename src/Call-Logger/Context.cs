using System.Data.Entity;
using Call_Logger.Models;

//PRIMARY CONTEXT FOR CALL-LOGGER APP

namespace Call_Logger
{
    public class Context : DbContext
    {
        public Context()
        {
            Database.SetInitializer(new DatabaseInitializer());
        }
        
        public DbSet<Call> Call { get; set; }

    }    
}


