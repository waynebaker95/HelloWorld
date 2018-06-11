using System;

namespace HelloWorldAPI
{
    public class Mobile : IHelloWorldType<Console>
    {
        public string WriteDbConfig { get; set; }
        public string PrintGreeting { get; set; }

    }
}