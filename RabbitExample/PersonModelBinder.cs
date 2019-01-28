using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;
using TestDTO;

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
            Company company = JsonConvert.DeserializeObject<Company>(bodyStr, new JsonPersonBaseConverter());
            
            bindingContext.Result = ModelBindingResult.Success(company);

            return Task.CompletedTask;
        }
    }
}
