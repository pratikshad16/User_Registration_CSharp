using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration
{
    public class UserRegistrationMain
    {
        string NamePattern = "^[A-Z][a-z]{2,}$";
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, NamePattern);
        }
        public bool ValidateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, NamePattern);
        }
    }
}
