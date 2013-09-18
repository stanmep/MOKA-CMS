using System;
using System.Collections.Generic;
using System.Linq;
<<<<<<< HEAD
using System.Runtime.InteropServices;
=======
>>>>>>> 3772518621f786f9dc89e015086e081494d14c5a
using System.Text;
using System.Web.Mvc;
using MokaCms.Services;
using NUnit.Framework;

namespace MokaCms.Web.UI.Tests
{
<<<<<<< HEAD
    [TestFixture]
    public class AccountServiceTest
    {
        #region SetUp / TearDown

        [SetUp]
        public void Init()
        { }

        [TearDown]
        public void Dispose()
        { }

        #endregion

        #region Tests

        [Test]
        [TestCase("robin", "robin", false)]
        [TestCase("patrick", "hayley", false)]
        public void LoginTest_GivenUsernamePassword_LoginConfirmed(string username, string password, bool authenticated)
        {

            var account = new AccountService();
            var result = account.Login(username, password);

            Assert.AreEqual(authenticated, result);

        }

        #endregion
    }
=======
	[TestFixture]
	public class AccountServiceTest
	{
		#region SetUp / TearDown

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
		[TestCase("patrick", "hayley", false)]
		public void Login_GivenUsernamePassword_LoginConfirmed(string username, string password, bool result)
		{
			var account = new AccountService();
			var authenticated = account.Authenticate(username, password);

			Assert.AreEqual(result, authenticated);
		}

		#endregion
	}
>>>>>>> 3772518621f786f9dc89e015086e081494d14c5a
}
