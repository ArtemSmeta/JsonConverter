using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testAPI
{
    public class JsonPersonConverter : JsonCreationConverter<Person>
    {
        protected override Person Create(Type objectType, JObject jsonObject)
        {

            if (jsonObject["Department"] != null)
            {
                return new Employee();
            }

            if (jsonObject["Name"] != null)
            {
                return new Child();
            }

            return null;
        }
    }
}
