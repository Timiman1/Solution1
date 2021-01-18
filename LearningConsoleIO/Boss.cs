using System;
using System.Collections.Generic;
using System.Text;

namespace LearningConsoleIO
{
    internal class Boss
    {
        //        Chefen har förnamn,
        ////efternamn, e-postadress och telefonnummer.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public string PhoneNumber { get; set; }
        public Boss(string firstName, string lastName, string email, string phonenum)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phonenum;
        }
        public void Print()
        {
            Console.WriteLine("Boss's first name: {0}", FirstName);
            Console.WriteLine("Boss's last name: {0}", LastName);
            Console.WriteLine("Email: {0}", Email);
            Console.WriteLine("Phone number: {0}", PhoneNumber);
        }
    }
}
