using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        /*** CRUD with HTTP
         * Create = POST
         * Read   = GET
         * Update = PUT
         * Delete = DELETE
         */

        [HttpGet]
        public string Greeting()
        {
            return "Howdy partner!";
        }

    }
}
