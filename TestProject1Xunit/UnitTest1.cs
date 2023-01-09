using Xunit.Abstractions;
using Xunit;
using System;

namespace TestProject1Xunit
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper testOUtputHelper;
        public UnitTest1(ITestOutputHelper testOutputHelper)
        {
                this.testOUtputHelper = testOutputHelper;
        }
        [Fact]
        public void Test1()
        {
            Console.WriteLine("first test");
            testOUtputHelper.WriteLine("Frist test");

        }
    }
}