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
        public void GivenFirstName_WhenStartsWithCapAndLessThanThreeChar_ShouldReturnTrue()
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
        public void GivenlastName_WhenStartsWithCapAndLessThanThreeChar_ShouldReturnTrue()
        {
            UserRegistrationMain userRegistration = new UserRegistrationMain();
            bool result = userRegistration.ValidateLastName("Dh");
            Assert.IsFalse(result);
        }
    }
}