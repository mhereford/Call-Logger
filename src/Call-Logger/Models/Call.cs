using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Call_Logger.Models
{
    public class Call
    {
        public int ID { get; set; }
        [Required]
        public DateTime Call_TS { get; set; }
        [Required, StringLength(100)]
        public string Call_Rep { get; set; }
        public int Registrant_ID { get; set; }
        public string Call_Status { get; set; }
        [Required, StringLength(500)]
        public string Call_Summary { get; set; }
        public string Call_Notes { get; set; }
        public string[] Call_Topics { get; set; }
    }
}