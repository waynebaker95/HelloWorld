using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;
using HelloWorldAPI;

namespace HelloWorldAPI
{
    public class Console : IHelloWorldType<Console>
    {
        public string WriteDbConfig { get; set; }
        public string PrintGreeting { get; set; }

    }
}