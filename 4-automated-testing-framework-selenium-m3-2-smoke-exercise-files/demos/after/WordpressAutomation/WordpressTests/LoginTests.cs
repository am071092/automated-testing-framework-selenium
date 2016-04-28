using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordpressAutomation;

namespace WordpressTests
{
    [TestClass]
    public class LoginTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void Admin_User_Can_Login()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("admin").WithPassword("password").Login();

            Assert.IsTrue(DashboardPage.IsAt, "Failed to login.");
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}
