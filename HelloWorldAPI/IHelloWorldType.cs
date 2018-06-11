using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldAPI
{
    public interface IHelloWorldType<T> where T : class
    {
        string WriteDbConfig { get; set; }
        
        string PrintGreeting { get; set; }   
    }
}
