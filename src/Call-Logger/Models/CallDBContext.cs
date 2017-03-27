using System.Data.Entity;

// CONTEXT FOR USER ACCOUNT - CREDENTIALS
namespace Call_Logger.Models
{
    public class CallDBContext : DbContext
    {
        public DbSet<UserAccount> userAccount { get; set; }
    }
}