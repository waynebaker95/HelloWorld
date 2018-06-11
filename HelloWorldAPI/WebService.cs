using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorldAPI
{
    public class WebService : IHelloWorldType<Console>
    {
        public string WriteDbConfig { get; set; }
        public string PrintGreeting { get; set; }
    }
}