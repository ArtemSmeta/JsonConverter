using System.Collections.Generic;
using Newtonsoft.Json;

namespace RabbitExample.DTO
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }

        //[JsonConverter(typeof(JsonPersonBaseConverter))]
        public IEnumerable<PersonBase> Persons { get; set; }
    }
}
