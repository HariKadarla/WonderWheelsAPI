using System;
using System.Collections.Generic;

#nullable disable

namespace WonderWheelsAPI.Models
{
    public partial class Record
    {
        public int TravelId { get; set; }
        public string TravelDate { get; set; }
        public string TravelTime { get; set; }
        public int TotalBookedSeats { get; set; }
        public int RouteId { get; set; }
        public int ProfitPerTrip { get; set; }

        public virtual Route Route { get; set; }
    }
}
