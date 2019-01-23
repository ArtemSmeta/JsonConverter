using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc.Internal;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Newtonsoft.Json;
using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace testAPI
{
    public class CustomModelBinder : IModelBinder
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

            
            var typeTask = JsonConvert.DeserializeObject<IEnumerable<Class1>>(bodyStr, new JsonPersonConverter());

            //bindingContext.Result = ModelBindingResult.Success(typeTask);

            return Task.CompletedTask;
        }
    }
}
