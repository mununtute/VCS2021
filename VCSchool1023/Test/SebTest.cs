

using NUnit.Framework;

namespace VCSchool1023.Test
{
    public class SebTest : BaseTest
    {
        [Test]
        public void TestLoan()
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
