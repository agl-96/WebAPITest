using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIModel.Model
{
    public class Response
    {
        public string? ResponseMessage { get; set; }
        public int StatusCode { get; set; }
        public dynamic? Result { get; set; }
    }
}
