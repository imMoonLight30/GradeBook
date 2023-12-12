using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GradeBookApp.tests
{
    public delegate string WriteLogDelegate(string logMessage);
    [TestClass]
    public class TypeTests
    {
        [TestMethod]
        public void WriteLogDelegateCanPointToMethod()
        {
            WriteLogDelegate log;
            //log = new WriteLogDelegate(ReturnMessage);
            log = ReturnMessage;
            var result = log("Hello!");
            Assert.AreEqual("Hello!",result);
        }
        string ReturnMessage(string message){
            return message;
        }
    }
}