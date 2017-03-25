using System.Data.Entity;
using Call_Logger.Models;
using System.Collections.Generic;

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


