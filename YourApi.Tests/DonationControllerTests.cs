using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourApi.Tests
{
    internal class DonationControllerTests
    {
        public class DonationController : ControllerBase
        {
            private readonly DonationServiceTests _service;

            public DonationController(DonationServiceTests service)
            {
                _service = service;
            }

            [HttpGet("{a:int}/{b:int}")]
            public IActionResult GetTotal(int a, int b) => Ok(_service.CalculateTotal(a, b));
        }
    }
}
