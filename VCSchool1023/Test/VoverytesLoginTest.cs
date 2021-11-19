

using NUnit.Framework;

namespace VCSchool1023.Test
{
    public class VoverytesLoginTest : BaseTest
    {
        [TestCase("g_survilaite@outlook.com", "tttttt", TestName = "Test New User LogIn Button")]
        public void TestNewUserLogInButton(string email, string password)
        {
            _loginPage.NavigateToDefaultPage()
                .InsertEmailAndPassword(email, password)
                .ClickLoginButton()
                .CheckLoginResult();
        }

    }
}
