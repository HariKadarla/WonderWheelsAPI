using System;
using System.Collections.Generic;

#nullable disable

namespace WonderWheelsAPI.Models
{
    public partial class UnauthorisedCustomerDetail
    {
        public UnauthorisedCustomerDetail()
        {
            UnauthorisedCustomerBookingDetails = new HashSet<UnauthorisedCustomerBookingDetail>();
        }

        public string Email { get; set; }
        public string ContactNo { get; set; }
        public string Name { get; set; }

        public virtual ICollection<UnauthorisedCustomerBookingDetail> UnauthorisedCustomerBookingDetails { get; set; }
    }
}
