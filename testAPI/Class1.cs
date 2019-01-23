using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testAPI
{
    [ModelBinder(typeof(CustomModelBinder))]
    public class Class1
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<Person> Cases { get; set; }
    }
}
