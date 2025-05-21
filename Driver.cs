using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRideDemo
{
    public class Driver {
        public string Name { get; set; }
        public bool IsAvailable { get; set; } = true;
        public int Fare { get; set; }  // Fare in VND
        public int ETA { get; set; }   // ETA in minutes

        public override string ToString() {
            return $"{Name} - {Fare:N0} VND, ETA: {ETA} mins";
        }
    }


}
