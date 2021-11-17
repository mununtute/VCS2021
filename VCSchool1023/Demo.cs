

using NUnit.Framework;
using System;
using System.Threading;

namespace VCSchool1103
{
    public class Demo
    {
        [Test]
        public static void TestIf4IsEven()
        {
            int leftover = 4 % 2;
            Assert.AreEqual(0, leftover, "4 is not even");
        }

        [Test]
        public static void TestNowIs19()
        {
            DateTime CurrentTime = DateTime.Now;
          
            Assert.IsTrue(CurrentTime.Hour.Equals(19), "Dabar ne 19 valanda");
            //Assert.AreEqual(19, CurrentTime.Hour, "Dabar ne 19 valanda");
        }
        [Test]
        public static void TestWaitFor5sec()
        {
            Thread.Sleep(5000);
        }

    }
}

    
       
