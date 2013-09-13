<<<<<<< HEAD
﻿using System;
=======
using System;
>>>>>>> cfca9fd5c11a8b213453f436df65df592c854f32
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
<<<<<<< HEAD
using Mokacms.Services;
using NUnit.Framework;


namespace MokaCms.Web.UI.Tests
{
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
        [TestCase("robin", "robin",true)]
        [TestCase("Bongmin","bongmin",false)]
        public void Login_GivenUsernamePassword_LoginConfirmed(string username, string password, bool authenticated)
        {
            var account = new AccountService();
            var result = account.Login(username, password);

            Assert.AreEqual(authenticated, result);

        }

        #endregion
    }

=======
using MokaCms.Services;
using NUnit.Framework;

namespace MokaCms.Web.UI.Tests
{
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
