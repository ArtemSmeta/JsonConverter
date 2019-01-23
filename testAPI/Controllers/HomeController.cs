using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using testAPI.Models;

namespace testAPI.Controllers
{

    [Produces("application/json")]
    [Route("api/Values")]
    [ApiController]
    public class HomeController : Controller
    {
        [HttpPost]
        public IActionResult Index([FromBody] Class1 nameParametr)
        {
            /*string json = @"[
{
  'FirstName': 'John',
  'LastName': 'Joinery',
  'Cases': [
{
  'BirthDate': '1983-02-02T00:00:00',
  'Department': 'Furniture',
  'JobTitle': 'Carpenter'
},
{
  'BirthDate': '2001-02-02T00:00:00',
  'Name': 'Artem',
  'Years': 15
},
{
  'BirthDate': '2001-02-02T00:00:00',
  'Name': 'Dima',
  'Years': 25
}
]
}
]";*/
           
            return Ok();
        }
    }
}
