//-----------------------------------------------------------------------
// <copyright file="UserRegistrationMain.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace User_Registration
{
    using System.Text.RegularExpressions;

    /// <summary>
    /// UserRegistrationMain class
    /// </summary>
    public class UserRegistrationMain
    {
        /// <summary>
        /// Regular expression pattern for name
        /// </summary>
        public readonly string NAMEPATTERN = "^[A-Z][a-z]{2,}$";

        /// <summary>
        /// Regular expression pattern for email
        /// </summary>
        public readonly string EMAILPATTERN = "^[0-9a-zA-Z]+([+_.-][0-9a-zA-Z]+)*@[a-zA-Z0-9]+([.][a-zA-Z]{2,3}){1,2}$";

        /// <summary>
        /// Regular expression pattern for mobile number
        /// </summary>
        public readonly string MOBILEPATTERN = "^[0-9]{2}[ ][0-9]{10}";

        /// <summary>
        /// Regular expression pattern for password
        /// </summary>
        public readonly string PASSWORDPATTERN = "(?=.*[a-z])(?=.*[0-9])(?=.*[A-Z])(?=.*[@#$%+!]{1}).{8,}";

        /// <summary>
        /// NamePattern matches with firstName.
        /// </summary>
        /// <param name="firstName">first name.</param>
       /// <returns> valid or Invalid.</returns>
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, this.NAMEPATTERN);
        }

        /// <summary>
        /// NamePattern matches with lastName.
        /// </summary>
        /// <param name="lastName">last name.</param>
        /// <returns> valid or invalid.</returns>
        public bool ValidateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, this.NAMEPATTERN);
        }

        /// <summary>
        /// Email Pattern matches with emailId.
        /// </summary>
        /// <param name="emailId"> emailId pattern.</param>
        /// <returns> valid or invalid.</returns>
        public bool ValidateEmail(string emailId)
        {
            return Regex.IsMatch(emailId, this.EMAILPATTERN);
        }

        /// <summary>
        /// Mobile Pattern matches with mobileNumber.
        /// </summary>
        /// <param name="mobileNumber"> mobileNumber pattern.</param>
        /// <returns> valid or invalid.</returns>
        public bool ValidateMobileNumber(string mobileNumber)
        {
            return Regex.IsMatch(mobileNumber, this.MOBILEPATTERN);
        }

        /// <summary>
        /// password regular expression pattern.
        /// </summary>
        /// <param name="passWord">passWord pattern.</param>
        /// <returns>valid or invalid.</returns>
        public bool ValidatePasswordPattern(string passWord)
        {
            return Regex.IsMatch(passWord, this.PASSWORDPATTERN);
        }
    }
}