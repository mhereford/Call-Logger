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


