using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Call_Logger.Models
{
    public class Call
    {
        public TopicFlags[] TopicFlags;

        public int CallID { get; set; }
        public string CustRep { get; set; }
        public DateTime CallTS { get; set; }
        public string CallStatus { get; set; }
        public int RegistrantID { get; set; }
        public string SummaryHtml { get; set; }
        public string CallNotes { get; set; }
    }
}