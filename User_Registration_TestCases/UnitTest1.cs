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
        public void GivenEmailId_WhenIsNotProper_ShouldReturnFalse()
        {
            UserRegistrationMain userRegistration = new UserRegistrationMain();
            bool result = userRegistration.ValidateEmail("dhagepratiksha16@gmail");
            Assert.IsFalse(result);
        }
    }
}