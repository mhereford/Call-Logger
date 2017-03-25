using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        [Required, StringLength(200)]
        public string Call_Summary { get; set; }
        [MaxLength(500, ErrorMessage = "The Notes Field cannot be longer than 500 characters.")]
        public string Notes { get; set; }
    }
}