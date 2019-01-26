using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RabbitExample.DTO;

namespace RabbitExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BinderController : ControllerBase
    {
        [HttpPost]
        [Route("TestBind")]
        public IActionResult TestBind([ModelBinder(BinderType = typeof(PersonModelBinder))][FromBody] Company company)
        {
            return Ok(company);
        }

        [HttpPost]
        [Route("TestWithoutBind")]
        public IActionResult TestWithoutBind([FromBody] Company company)
        {
            return Ok(company);
        }
    }
}