using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Odemeter.Models
{
    public class Transporter
    {
        public int ID { get; set; }
        [DisplayName("Transporter Name")]
        public string Name { get; set; }
        [DisplayName("Time Stamp")]
        public DateTime TimeStamp { get; set; }

        public Transporter()
        {
            TimeStamp = DateTime.Now;
        }
    }
}