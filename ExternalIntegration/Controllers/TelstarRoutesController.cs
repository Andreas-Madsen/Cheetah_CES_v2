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
        public TelstarRoutes Get([FromBody] TelstarRequest telstarRequest) 
        {
            return new TelstarRoutes {
                Price = 3,
                Time = 20,
                Error = "NO_ERROR"
            };
        }
    }
}
