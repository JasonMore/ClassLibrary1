using ClassLibrary1;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    [TestFixture]
    public class Class1Tests
    {
        [Test]
        public void TheTest()
        {
            var class1 = new Class1();
            Assert.AreEqual("Foo Bar", class1.DoStuff());

        }
    }
}
