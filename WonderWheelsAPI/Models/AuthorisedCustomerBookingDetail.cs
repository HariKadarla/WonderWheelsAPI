using System;
using System.Collections.Generic;

#nullable disable

namespace WonderWheelsAPI.Models
{
    public partial class AuthorisedCustomerBookingDetail
    {
        public int TicketId { get; set; }
        public int CustomerId { get; set; }
        public int BusId { get; set; }
        public int RouteId { get; set; }
        public string DepartureTime { get; set; }
        public string DepartureDate { get; set; }
        public string ArrivalTime { get; set; }
        public string ArrivalDate { get; set; }
        public string ReturnDepartureTime { get; set; }
        public string ReturnDepartureDate { get; set; }
        public string ReturnArrivalTime { get; set; }
        public string ReturnArrivalDate { get; set; }
        public string TicketType { get; set; }
        public int? NoOfSeats { get; set; }
        public string SeatIds { get; set; }
        public int TotalPrice { get; set; }
        public int? DriverId { get; set; }
        public string TripStatus { get; set; }

        public virtual BusDetail Bus { get; set; }
        public virtual AuthorisedCustomerDetail Customer { get; set; }
        public virtual DriverDetail Driver { get; set; }
        public virtual Route Route { get; set; }
    }
}
