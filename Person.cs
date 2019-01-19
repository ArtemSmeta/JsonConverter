using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testAPI
{
    public class Person
    {
        public DateTime BirthDate { get; set; }
    }

    public class Employee : Person
    {
        public string Department { get; set; }
        public string JobTitle { get; set; }
    }

    public class Child : Person
    {
        public string Years { get; set; }
        public string Name { get; set; }
    }
}
