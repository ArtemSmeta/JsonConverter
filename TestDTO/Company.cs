using System;
using System.Collections.Generic;

namespace TestDTO
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        
        public IEnumerable<PersonBase> Persons { get; set; }
    }
}
