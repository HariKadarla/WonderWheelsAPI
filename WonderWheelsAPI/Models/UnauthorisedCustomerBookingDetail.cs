using System;
using System.Collections.Generic;

#nullable disable

namespace WonderWheelsAPI.Models
{
    public partial class UnauthorisedCustomerBookingDetail
    {
        public int BookingId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public int RouteId { get; set; }
        public string DepartureTime { get; set; }
        public string DepartureDate { get; set; }
        public string ArrivalTime { get; set; }
        public string ArrivalDate { get; set; }
        public string ReturnDate { get; set; }
        public string TicketType { get; set; }
        public int NoOfSeats { get; set; }
        public string SeatIds { get; set; }
        public int TotalPrice { get; set; }
        public int? DriverId { get; set; }
        public string TripStatus { get; set; }

        public virtual DriverDetail Driver { get; set; }
        public virtual UnauthorisedCustomerDetail EmailNavigation { get; set; }
        public virtual Route Route { get; set; }
    }
}
