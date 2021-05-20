using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ExternalIntegration.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TelstarRoutesController : ControllerBase
    {
        private readonly ILogger<TelstarRoutesController> _logger;

        public TelstarRoutesController(ILogger<TelstarRoutesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<TelstarRoutes> Get() 
        {
            var rng = new Random();
            return Enumerable.Range(0, 4).Select(index => new TelstarRoutes {
                Price = 20,
                Time = 20
            }).ToArray();
        }
    }
}
