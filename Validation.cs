using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class Validation
    {
        public const string NAME_REGEX = "^[A-Z]{1}[a-z]{2,}$";
        public const string EMAIL_PATTERN = "^[0-9a-zA-Z]+[.+-]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
        public void Validate(string name) 
        {
            if (Regex.IsMatch(name, NAME_REGEX))
            {
                Console.WriteLine("User firstName is valid");
            }
            else
            {
                Console.WriteLine("User firstName is invalid");
            }
        }
        public void ValidateLastName(string name)
        {
            if (Regex.IsMatch(name, NAME_REGEX))
            {
                Console.WriteLine("User lastName is valid");
            }
            else
            {
                Console.WriteLine("User lastName is invalid");
            }
        }
        public void ValidateEmail(string email)
        {
            if (Regex.IsMatch(email, EMAIL_PATTERN))
            {
                Console.WriteLine("User Email is valid");
            }
            else
            {
                Console.WriteLine("User Email is invalid");
            }
        }
    }
}
