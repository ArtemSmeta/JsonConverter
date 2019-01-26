using System;
using Newtonsoft.Json.Linq;
using RabbitExample.DTO;

namespace RabbitExample
{
    public class JsonPersonBaseConverter : JsonCreationConverter<PersonBase>
    {
        protected override PersonBase Create(Type objectType, JObject jsonObject)
        {
            if (jsonObject["Department"] != null)
            {
                return new Employee();
            }

            if (jsonObject["Years"] != null)
            {
                return new Child();
            }

            return null;
        }
    }
}
