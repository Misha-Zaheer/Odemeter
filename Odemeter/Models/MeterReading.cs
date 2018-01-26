using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Odemeter.Models
{
    public class MeterReading
    {
        public int ID { get; set; }
        // foreign key
        //[HiddenInput(DisplayValue = false)]
        public int TransporterID { get; set; }
        public string Address { get; set; }
        public string Odemeter { get; set; }
        [DisplayName("Time Stamp")]
        public DateTime TimeStamp { get; set; }
        [DisplayName("File URL")]
        public string fileURL { get; set; }

        public MeterReading()
        {
            TimeStamp = DateTime.Now;
        }
    }
}