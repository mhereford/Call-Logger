using System.Collections.Generic;
using System.Linq;
using Call_Logger.Models;

namespace Call_Logger.Data
{
    /// <summary>
    /// Repository for calls.

    /// </summary>
    public class TopicFlagRepository
    {
        /// <summary>
        /// Returns a collection of topics.
        /// </summary>
        /// <returns>A list of topics.</returns>
        public List<TopicFlags> GetTopicFlags()
        {
            return Data.TopicFlags
                .OrderBy(a => a.TopicName)
                .ToList();
        }
    }
}