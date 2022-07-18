using Microsoft.AspNetCore.Mvc;
using System;

namespace RestWithASPNETUdemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {

        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        // Operation Sum
        [HttpGet("get/")]
        public IActionResult Get()
        {
            

            return BadRequest("Invalid Input");
        }
    }
}
