using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRideDemo
{
    public class Ride {
        public string CustomerName { get; set; }
        public string DriverName { get; set; }
        public string PickupLocation { get; set; }
        public string DropoffLocation { get; set; }
        public string Status { get; set; } = "Pending";
        public bool Paid { get; set; } = false;
        public int Fare { get; set; }
        public int ETA { get; set; }


        public override string ToString() {
            return $"{CustomerName} - {PickupLocation} → {DropoffLocation} (Driver: {DriverName}, Status: {Status})";
        }
    }


}
