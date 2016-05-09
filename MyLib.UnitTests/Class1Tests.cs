using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib.UnitTests
{
    public class Class1Tests
    {
        [Test]
        public void CanCreateInstance()
        {
            var target = new Class1();
            Assert.IsInstanceOf<Class1>(target);
        }
    }
}
