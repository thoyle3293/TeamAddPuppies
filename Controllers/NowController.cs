using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CSDay01.Data;

namespace CSDay01.Controllers
{
    [Produces("application/json")]
    [Route("api/Now")]
    public class NowController : Controller
    {
        // GET: api/Now/5
        [HttpGet()]
        public string GetNow()
        {
            return "Abracadambra";
        }
    }

}