using System;

namespace UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User registration");

            Validation validate = new Validation();
            validate.Validate("mukul");
        }
    }
}
