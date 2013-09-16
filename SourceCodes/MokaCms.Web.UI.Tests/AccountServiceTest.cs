using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
<<<<<<< HEAD
using MokaCMS.Services;
=======
using MokaCms.Services;
>>>>>>> cfca9fd5c11a8b213453f436df65df592c854f32
using NUnit.Framework;

namespace MokaCms.Web.UI.Tests
{
<<<<<<< HEAD
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
>>>>>>> cfca9fd5c11a8b213453f436df65df592c854f32
}
