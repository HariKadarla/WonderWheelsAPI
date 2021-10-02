using System;
using System.Collections.Generic;

#nullable disable

namespace WonderWheelsAPI.Models
{
    public partial class CoachReservationDetail
    {
        public int ReservationId { get; set; }
        public int CustomerId { get; set; }
        public string WithDriver { get; set; }
        public int? CoachBusId { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public string DepartureTime { get; set; }
        public string DepartureDate { get; set; }
        public string ArrivalTime { get; set; }
        public string ArrivalDate { get; set; }
        public string ReturnDepartureTime { get; set; }
        public string ReturnDepartureDate { get; set; }
        public string ReturnArrivalTime { get; set; }
        public string ReturnArrivalDate { get; set; }
        public string OutDate { get; set; }
        public string InDate { get; set; }
        public int? Price { get; set; }
        public string SecurityDeposit { get; set; }
        public int? DepositAmount { get; set; }

        public virtual CoachResevationBusDetail CoachBus { get; set; }
        public virtual AuthorisedCustomerDetail Customer { get; set; }
    }
}
