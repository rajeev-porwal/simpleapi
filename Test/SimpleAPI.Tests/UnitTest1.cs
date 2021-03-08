using System;
using SimpleAPI.Controllers;
using Xunit;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
        ValuesController vobj= new ValuesController();
        [Fact]
        public void Test1()
        {
            var result=vobj.Get(1);
            Assert.Equal("Rajeev Porwal",result.Value);
//hello
        }
    }
}
