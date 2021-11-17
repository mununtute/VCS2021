using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSchool1023.Test
{
    public class SebTest : BaseTest
    {
        [Test]
        public static void TestLoan()
        {
            _sebPage.NavigateToDefaultPage()
                .FocusOnFrame()
                .InsertIncome("1000")
                .SelectCityFromDropDownByValue("Klaipeda")
                .CalculateLoan()
                .CheckResult(75000);
        }
    }
}
