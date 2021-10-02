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
    public class UserAuthController : ControllerBase
    {
        public IConfiguration _configuration;

        private readonly WonderWheelsDBContext _context;

        public UserAuthController(WonderWheelsDBContext context)
        {
            _context = context;
        }
        [HttpPost]

        public async Task<ActionResult<AuthorisedCustomerDetail>> Post(AuthorisedCustomerDetail _account)
        {
            if (_account != null && _account.LoginId != null && _account.Password != null)
            {
                AuthorisedCustomerDetail accountCustomer = await GetAccount(_account.LoginId, _account.Password);

                if (accountCustomer != null)
                {
                    return accountCustomer;
                }
                else
                {
                    return BadRequest("Invalid credentials");
                }
            }
            else
            {
                return BadRequest();
            }
        }
        private async Task<AuthorisedCustomerDetail> GetAccount(string loginid, string password)
        {
            return await _context.AuthorisedCustomerDetails.FirstOrDefaultAsync(u => u.LoginId == loginid && u.Password == password);
        }

    }
}
