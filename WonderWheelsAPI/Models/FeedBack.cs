using System;
using System.Collections.Generic;

#nullable disable

namespace WonderWheelsAPI.Models
{
    public partial class FeedBack
    {
        public int FeedbackId { get; set; }
        public string CustomerName { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public string TripDate { get; set; }
        public int ComfortLevel { get; set; }
        public string DriverOverSpeed { get; set; }
        public int DriversRating { get; set; }
        public string BusReachedOnTime { get; set; }
        public string Remarks { get; set; }
    }
}
