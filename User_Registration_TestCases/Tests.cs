//-----------------------------------------------------------------------
// <copyright file="Tests.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace User_Registration_TestCases
{
    using NUnit.Framework;
    using User_Registration;

    /// <summary>
    /// Test Class
    /// </summary>
    public class Tests
    {
        /// <summary>
        ///  Method SetUp
        /// </summary>
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Test Method to validate first name
        /// </summary>
        [Test]
        public void GivenFirstName_WhenStartsWithCapAndMinThreeChar_ShouldReturnTrue()
        {
            UserRegistrationMain userRegistration = new UserRegistrationMain();
            bool result = userRegistration.ValidateFirstName("Pratiksha");
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test Method to validate first name
        /// </summary>
        [Test]
        public void GivenFirstName_WhenStartsWithCapAndLessThanThreeChar_ShouldReturnFalse()
        {
            UserRegistrationMain userRegistration = new UserRegistrationMain();
            bool result = userRegistration.ValidateFirstName("Pr");
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test Method to validate last name
        /// </summary>
        [Test]
        public void GivenLastName_WhenStartsWithCapAndMinThreeChar_ShouldReturnTrue()
        {
            UserRegistrationMain userRegistration = new UserRegistrationMain();
            bool result = userRegistration.ValidateLastName("Dhage");
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test Method to validate last name
        /// </summary>
        [Test]
        public void GivenlastName_WhenStartsWithCapAndLessThanThreeChar_ShouldReturnFalse()
        {
            UserRegistrationMain userRegistration = new UserRegistrationMain();
            bool result = userRegistration.ValidateLastName("Dh");
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test Method to validate email
        /// </summary>
        [Test]
        public void GivenEmailId_WhenProper_ShouldReturnTrue()
        {
            UserRegistrationMain userRegistration = new UserRegistrationMain();
            bool result = userRegistration.ValidateEmail("dhagepratiksha16@gmail.com");
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test Method to validate email
        /// </summary>
        [Test]
        public void GivenEmailId_WhenIsNotProper_ShouldReturnFalse()
        {
            UserRegistrationMain userRegistration = new UserRegistrationMain();
            bool result = userRegistration.ValidateEmail("dhagepratiksha16@gmail");
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test Method to validate mobile number
        /// </summary>
        [Test]
        public void GivenMobileNumber_WhenProper_ShouldReturnTrue()
        {
            UserRegistrationMain userRegistration = new UserRegistrationMain();
            bool result = userRegistration.ValidateMobileNumber("91 99865467843");
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test Method to validate mobile number
        /// </summary>
        [Test]
        public void GivenMobileNumber_WhenLessThanTenDigits_ShouldReturnFalse()
        {
            UserRegistrationMain userRegistration = new UserRegistrationMain();
            bool result = userRegistration.ValidateMobileNumber("71 765437896");
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test Method to validate mobile number
        /// </summary>
        [Test]
        public void GivenMobileNumber_WhenNoSpaceAfterCountryCode_ShouldReturnFalse()
        {
            UserRegistrationMain userRegistration = new UserRegistrationMain();
            bool result = userRegistration.ValidateMobileNumber("717654378967");
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test Method to validate password
        /// </summary>
        [Test]
        public void GivenPassword_WhenWithMinimumEightChracters_ShouldReturnTrue()
        {
            UserRegistrationMain userRegistration = new UserRegistrationMain();
            bool result = userRegistration.ValidatePasswordPattern("Pra#thb5f");
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test Method to validate password
        /// </summary>
        [Test]
        public void GivenPassword_WhenLessThanEightChracters_ShouldReturnFalse()
        {
            UserRegistrationMain userRegistration = new UserRegistrationMain();
            bool result = userRegistration.ValidatePasswordPattern("Prathb5");
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test Method to validate password
        /// </summary>
        [Test]
        public void GivenPassword_WhenNotContainUpperCaseChar_ShouldReturnFalse()
        {
            UserRegistrationMain userRegistration = new UserRegistrationMain();
            bool result = userRegistration.ValidatePasswordPattern("prathkntf");
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test Method to validate password
        /// </summary>
        [Test]
        public void GivenPassword_WhenNotContainNumericNumber_ShouldReturnFalse()
        {
            UserRegistrationMain userRegistration = new UserRegistrationMain();
            bool result = userRegistration.ValidatePasswordPattern("Pratbghfd");
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test Method to validate password
        /// </summary>
        [Test]
        public void GivenPassword_WhenContainMoreNumericNumber_ShouldReturnTrue()
        { 
           UserRegistrationMain userRegistration = new UserRegistrationMain();
           bool result = userRegistration.ValidatePasswordPattern("Pra@tb5h7d");
           Assert.IsTrue(result);
        }

        /// <summary>
        /// Test Method to validate password
        /// </summary>
        [Test]
        public void GivenPassword_WhenNotContainSpecialChar_ShouldReturnFalse()
        {
            UserRegistrationMain userRegistration = new UserRegistrationMain();
            bool result = userRegistration.ValidatePasswordPattern("Pratb5h7d");
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test Method to validate all email samples
        /// </summary>
        [Test]
        public void GivenEmails_WhenChecked_ShouldReturnExpectedResult()
        {
            UserRegistrationMain userRegistration = new UserRegistrationMain();
            Assert.IsTrue(userRegistration.ValidateEmail("abc@yahoo.com"));
            Assert.IsTrue(userRegistration.ValidateEmail("abc-100@yahoo.com"));
            Assert.IsTrue(userRegistration.ValidateEmail("abc.100@yahoo.com"));
            Assert.IsTrue(userRegistration.ValidateEmail("abc111@abc.com"));
            Assert.IsTrue(userRegistration.ValidateEmail("abc-100@abc.net"));
            Assert.IsTrue(userRegistration.ValidateEmail("abc.100@abc.com.au"));
            Assert.IsTrue(userRegistration.ValidateEmail("abc@1.com"));
            Assert.IsTrue(userRegistration.ValidateEmail("abc@gmail.com.com"));
            Assert.IsTrue(userRegistration.ValidateEmail("abc+100@gmail.com"));
            Assert.IsFalse(userRegistration.ValidateEmail("abc"));
            Assert.IsFalse(userRegistration.ValidateEmail("abc123@gmail.a"));
            Assert.IsFalse(userRegistration.ValidateEmail("abc123@.com"));
            Assert.IsFalse(userRegistration.ValidateEmail("abc123@.com.com"));
            Assert.IsFalse(userRegistration.ValidateEmail(".abc@abc.com"));
            Assert.IsFalse(userRegistration.ValidateEmail("abc()*@gmail.com"));
            Assert.IsFalse(userRegistration.ValidateEmail("abc@%*.com"));
            Assert.IsFalse(userRegistration.ValidateEmail("abc..2002@gmail.com"));
            Assert.IsFalse(userRegistration.ValidateEmail("abc.@gmail.com"));
            Assert.IsFalse(userRegistration.ValidateEmail("abc@abc@gmail.com"));
            Assert.IsFalse(userRegistration.ValidateEmail("abc@gmail.com.2a"));
            Assert.IsFalse(userRegistration.ValidateEmail("abc@gmail.com.aa.au"));
        }
    }
}