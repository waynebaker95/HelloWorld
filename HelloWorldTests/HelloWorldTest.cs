using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using HelloWorldAPI;

namespace HelloWorldTests
{
    [TestFixture]
    public class HelloWorldTest
    {
        [Test]
        public void PrintGreeting_ReturnGreeting_WhenInitialized()
        {
            var console = new HelloWorldAPI.Console();

            console.PrintGreeting = "Hello World";
            var result = console.PrintGreeting;

            Assert.That(console.PrintGreeting.Equals(result));

        }
    }
}
