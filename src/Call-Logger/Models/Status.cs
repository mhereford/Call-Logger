using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Call_Logger.Models
{
    public class Status
    {
        public enum StatusType
        {
            Open = 1,
            Hold = 2,
            Closed = 3
        }

        public Status(StatusType statusType, string name = null)
        {
            Id = (int)statusType;

            name = name ?? statusType.ToString();
        }

        public int Id { get; set; }

        public string Name { get; set; }
    }

}