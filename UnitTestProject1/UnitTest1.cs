using System;
using BE;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private BE.Person person = new Person
        {
            ID = 123,
            FirstName = "moshe",
            LastName = "zuchmir"
        };
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine(person);
           // Assert.AreEqual("lo nachon",person.ToString());
        }
    }
}
