using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRequest.Models
{
    public class GenericResponse<T>
    {
        public T result { get; set; }
        public string status { get; set; }
        public string errorMessage { get; set; }
        public string errorDetails { get; set; }
    }
}
