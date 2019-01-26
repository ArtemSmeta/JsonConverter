using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;
using RabbitExample.DTO;

namespace RabbitExample
{
    public class PersonModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            if (bindingContext == null)
                throw new ArgumentNullException(nameof(bindingContext));

            var request = bindingContext.HttpContext.Request;
            var bodyStr = "";
            using (StreamReader sr = new StreamReader(request.Body, Encoding.UTF8))
            {
                bodyStr = sr.ReadToEnd();
            }

            // Создаем главный класс Company
            Company company = JsonConvert.DeserializeObject<Company>(bodyStr);

            //// вытащили строку с нашим массивом
            //var typeTask = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(bodyStr)["Persons"].ToString();

            //// конвертировали ее при помощи JsonPersonBaseConverter
            //var persons = JsonConvert.DeserializeObject<IEnumerable<PersonBase>>(typeTask, new JsonPersonBaseConverter());

            //company.Persons = persons;            
            bindingContext.Result = ModelBindingResult.Success(company);

            return Task.CompletedTask;
        }
    }
}
