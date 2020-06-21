using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers {
    [ApiController]
    [Route ("[controller]")]
    public class HelloController : ControllerBase {
        public HelloController () {

        }

        [HttpGet]
        public string Get () {
            return "Hello...";
        }
    }
}