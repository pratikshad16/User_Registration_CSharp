using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration
{
    public class UserRegistrationMain
    {
        string NamePattern = "^[A-Z][a-z]{2,}$";
        string EmailPattern = "^[0-9a-zA-Z]+([+_.-][0-9a-zA-Z]+)*@[a-zA-Z0-9]+([.][a-zA-Z]{2,3}){1,2}$";
        string MobilePattern = "^[0-9]{2}[ ][0-9]{10}";
        string PasswordPattern = "(?=.*[a-z])(?=.*[0-9])(?=.*[A-Z])(?=.*[@#$%+!]{1}).{8,}";
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, NamePattern);
        }
        public bool ValidateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, NamePattern);
        }
        public bool ValidateEmail(string emailId)
        {
            return Regex.IsMatch(emailId, EmailPattern);
        }
        public bool ValidateMobileNumber(string mobileNumber)
        {
            return Regex.IsMatch(mobileNumber, MobilePattern);
        }
        public bool ValidatePasswordPattern(string passWord)
        {
            return Regex.IsMatch(passWord, PasswordPattern);
        }
    }
}
