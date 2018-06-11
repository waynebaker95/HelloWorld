using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorldAPI
{
    public abstract class HelloWorldType 
    {
        public string Name { get; set; }

        public abstract void CreateTypeInstance(string clientType, string writeToLocation);
        
    }
}