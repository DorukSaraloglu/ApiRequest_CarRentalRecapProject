using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRequest.Models
{
    public class CarList
    {
        public List<Car> Data { get; set; }
        public string Success { get; set; }
        public string Message { get; set; }
    }
}
