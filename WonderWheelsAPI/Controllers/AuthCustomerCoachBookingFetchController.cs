using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Added...

using WonderWheelsAPI.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace WonderWheelsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthCustomerCoachBookingFetchController : ControllerBase
    {
        public IConfiguration _configuration;

        private readonly WonderWheelsDBContext _context;

        public AuthCustomerCoachBookingFetchController(WonderWheelsDBContext context)
        {
            _context = context;
        }
        [HttpPost]

        public async Task<ActionResult<IEnumerable<CoachReservationDetail>>> Post(CoachReservationDetail _booking)
        {
            if (_booking != null && _booking.CustomerId != 0)
            {
                List<CoachReservationDetail> bookings = await _context.CoachReservationDetails.Where(b => b.CustomerId == _booking.CustomerId).ToListAsync();


                if (bookings != null)
                {
                    return bookings;
                }
                else
                {
                    return BadRequest("No Route Found");
                }
            }
            else
            {
                return BadRequest("Input Source and Destination");
            }
        }
    }
}