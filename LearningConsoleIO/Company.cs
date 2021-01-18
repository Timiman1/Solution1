using System;
using System.Collections.Generic;
using System.Text;

namespace LearningConsoleIO
{
//    Ett företag har namn, adress, telefonnummer,
////faxnummer, hemsida och chef.
    internal class Company
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Phonenumber { get; set; }
        public string Fax { get; set; }
        public string Website { get; set; }
        public Boss Boss { get; set; }

        public Company(string name, string address, string phonenum, string fax, string website, Boss boss)
        {
            Name = name;
            Adress = address;
            Phonenumber = phonenum;
            Fax = fax;
            Website = website;
            Boss = boss;
        }
        public void Print()
        {
            Console.WriteLine("Company Name: {0}", Name);
            Console.WriteLine("Adress: {0}", Adress);
            Console.WriteLine("Company Phone number: {0}", Phonenumber);
            Console.WriteLine("Company Fax: {0}", Fax);
            Console.WriteLine("Company Website: {0}", Website);
        }
    }
}
