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
    }
}
