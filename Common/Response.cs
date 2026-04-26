using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Common
{
    public class Response
    {
        public string JsonData { get; set; }
        public bool isSuccessful { get; set; }
        public string Message { get; set; }
        public T getData<T>()
        {
            return JsonSerializer.Deserialize<T>(JsonData);
        }
    }
}
