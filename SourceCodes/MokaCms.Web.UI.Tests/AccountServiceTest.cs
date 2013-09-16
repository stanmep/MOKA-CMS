using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using MokaCMS.Services;
using NUnit.Framework;

namespace MokaCms.Web.UI.Tests
{
    [TestFixture]
    public class AccountServiceTest
    {
        #region SetUp / TearDown

        // Common executable mothod for testing
        [SetUp]
        public void Init()
        { }

        
        [TearDown]
        public void Dispose()
        { }

        #endregion

        #region Tests

        [Test]
        [TestCase("robin", "robin", true)]
        [TestCase("patrick", "robin", false)]
        public void LoginTest_GivenUsernamePassword_LoginConfirmed(string username, string password, bool authenticated)
        {

            var account = new AccountService();
            var result = account.Login(username, password);

            Assert.AreEqual(authenticated, result);
        }

        #endregion
    }

   
}
