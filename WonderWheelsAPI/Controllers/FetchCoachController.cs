using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using WonderWheelsAPI.Models;
namespace WonderWheelsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FetchCoachController : ControllerBase
    {

        public IConfiguration _configuration;

        private readonly WonderWheelsDBContext _context;

        public FetchCoachController(WonderWheelsDBContext context)
        {
            _context = context;
        }
        [HttpPost]

        public async Task<ActionResult<IEnumerable<CoachResevationBusDetail>>> Post(CoachResevationBusDetail _coach)
        {
            if (_coach != null && _coach.RouteId != 0 && _coach.DepartureDate != null)
            {
                List<CoachResevationBusDetail> buses = await _context.CoachResevationBusDetails.Where(b => b.RouteId == _coach.RouteId && b.DepartureDate == _coach.DepartureDate).ToListAsync();


                if (buses != null)
                {
                    return buses;
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
        /*
        private async Task<List<BusDetail>> GetBuses(int routeid, DateTime? departuredate)
        {
             return  (List<BusDetail>) _context.BusDetails.ToList().Where(u => u.RouteId == routeid && u.DepartureDate == departuredate);
        } */
    }
}