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
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string json = @"[
{
  'FirstName': 'John',
  'LastName': 'Joinery',
  'Cases': 
[{
  'BirthDate': '1983-02-02T00:00:00',
  'Department': 'Furniture',
  'JobTitle': 'Carpenter'
},
{
  'BirthDate': '2001-02-02T00:00:00',
  'Name': 'Artem',
  'Years': '15'
},
{
  'BirthDate': '2001-02-02T00:00:00',
  'Name': 'Dima',
  'Years': '25'
}
]
}
]";
            var person = JsonConvert.DeserializeObject<List<Class1>>(json, new JsonPersonConverter());
            
            return View();
        }
    }
}
