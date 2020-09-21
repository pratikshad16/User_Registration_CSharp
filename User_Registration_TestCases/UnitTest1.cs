using NUnit.Framework;
using User_Registration;

namespace User_Registration_TestCases
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenFirstName_WhenStartsWithCapAndMinThreeChar_ShouldReturnTrue()
        {
            UserRegistrationMain userRegistration = new UserRegistrationMain();
            bool result = userRegistration.ValidateFirstName("Pratiksha");
            Assert.IsTrue(result);
        }
        [Test]
        public void GivenFirstName_WhenStartsWithCapAndLessThanThreeChar_ShouldReturnFalse()
        {
            UserRegistrationMain userRegistration = new UserRegistrationMain();
            bool result = userRegistration.ValidateFirstName("Pr");
            Assert.IsFalse(result);
        }
        [Test]
        public void GivenLastName_WhenStartsWithCapAndMinThreeChar_ShouldReturnTrue()
        {
            UserRegistrationMain userRegistration = new UserRegistrationMain();
            bool result = userRegistration.ValidateLastName("Dhage");
            Assert.IsTrue(result);
        }
        [Test]
        public void GivenlastName_WhenStartsWithCapAndLessThanThreeChar_ShouldReturnFalse()
        {
            UserRegistrationMain userRegistration = new UserRegistrationMain();
            bool result = userRegistration.ValidateLastName("Dh");
            Assert.IsFalse(result);
        }
        [Test]
        public void GivenEmailId_WhenProper_ShouldReturnTrue()
        {
            UserRegistrationMain userRegistration = new UserRegistrationMain();
            bool result = userRegistration.ValidateEmail("dhagepratiksha16@gmail.com");
            Assert.IsTrue(result);
        }
        [Test]
        public void GivenEmailId_WhenIsNotProper_ShouldReturnFalse()
        {
            UserRegistrationMain userRegistration = new UserRegistrationMain();
            bool result = userRegistration.ValidateEmail("dhagepratiksha16@gmail");
            Assert.IsFalse(result);
        }
        [Test]
        public void GivenMobileNumber_WhenProper_ShouldReturnTrue()
        {
            UserRegistrationMain userRegistration = new UserRegistrationMain();
            bool result = userRegistration.ValidateMobileNumber("91 99865467843");
            Assert.IsTrue(result);
        }
        [Test]
        public void GivenMobileNumber_WhenLessThanTenDigits_ShouldReturnFalse()
        {
            UserRegistrationMain userRegistration = new UserRegistrationMain();
            bool result = userRegistration.ValidateMobileNumber("71 765437896");
            Assert.IsFalse(result);
        }
        [Test]
        public void GivenMobileNumber_WhenNoSpaceAfterCountryCode_ShouldReturnFalse()
        {
            UserRegistrationMain userRegistration = new UserRegistrationMain();
            bool result = userRegistration.ValidateMobileNumber("717654378967");
            Assert.IsFalse(result);
        }
        [Test]
        public void GivenPassword_WhenWithMinimumEightChracters_ShouldReturnTrue()
        {
            UserRegistrationMain userRegistration = new UserRegistrationMain();
            bool result = userRegistration.ValidatePasswordPattern("Prathb5f");
            Assert.IsTrue(result);
        }
        [Test]
        public void GivenPassword_WhenLessThanEightChracters_ShouldReturnFalse()
        {
            UserRegistrationMain userRegistration = new UserRegistrationMain();
            bool result = userRegistration.ValidatePasswordPattern("Prathb5");
            Assert.IsFalse(result);
        }
        [Test]
        public void GivenPassword_WhenNotContainUpperCaseChar_ShouldReturnFalse()
        {
            UserRegistrationMain userRegistration = new UserRegistrationMain();
            bool result = userRegistration.ValidatePasswordPattern("prathkntf");
            Assert.IsFalse(result);
        }
    }
}