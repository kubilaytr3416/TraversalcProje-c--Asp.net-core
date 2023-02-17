using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public int AppUserID { get; set; }
        public String PersonCount { get; set; }
        //public String Destination { get; set; }
        public String Description { get; set; }
        public AppUser AppUser { get; set; }
        public DateTime ReservastionDate { get; set; }
        public string  Status { get; set; }
        public int DestinationID { get; set; }
        public Destination Destination { get; set; }
    }

}
