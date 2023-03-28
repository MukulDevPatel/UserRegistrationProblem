using System;

namespace UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User registration");

            Validation validate = new Validation();
            validate.Validate("Mukul");
            validate.ValidateLastName("Patel");
            validate.ValidateEmail("abc.xyz@bl.co.in");
        }
    }
}
