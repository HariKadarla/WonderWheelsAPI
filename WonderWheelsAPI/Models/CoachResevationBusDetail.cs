using System;
using System.Collections.Generic;

#nullable disable

namespace WonderWheelsAPI.Models
{
    public partial class CoachResevationBusDetail
    {
        public CoachResevationBusDetail()
        {
            CoachReservationDetails = new HashSet<CoachReservationDetail>();
        }

        public int CoachBusId { get; set; }
        public int? RouteId { get; set; }
        public string DepartureTime { get; set; }
        public string DepartureDate { get; set; }
        public string ArrivalTime { get; set; }
        public string ArrivalDate { get; set; }
        public int TotalSeats { get; set; }
        public string Status { get; set; }
        public int? DriverId { get; set; }

        public virtual DriverDetail Driver { get; set; }
        public virtual Route Route { get; set; }
        public virtual ICollection<CoachReservationDetail> CoachReservationDetails { get; set; }
    }
}
