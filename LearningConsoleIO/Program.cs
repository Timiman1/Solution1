using System;

namespace LearningConsoleIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Ovning06();
        }

//        1. Skriv ett program som läser tre heltal från konsolen
//och skriver ut deras summa

        static void Ovning01()
        {
            Console.WriteLine("Please type 3 numbers separated by comma (,)");
            string[] stringArray = Console.ReadLine().Split(',');
            int sum = 0;
            foreach (var str in stringArray)
            {
                sum += int.Parse(str);
            }
            Console.WriteLine(sum);
        }
//2. Skriv ett program som läser radien r för en cirkel och
//skriver ut dess omkrets och area

        static void Ovning02()
        {
            Console.WriteLine("Enter a radius for a circle");

            string input = Console.ReadLine();
            int radius = int.Parse(input);
            double circ = Math.PI * (radius * 2);
            double area = Math.PI * radius * radius;
            Console.WriteLine("Circumference = {0:0.000}", circ);
            Console.WriteLine("Area = {0:0.000}", area);
        }
//3. Ett företag har namn, adress, telefonnummer,
//faxnummer, hemsida och chef.Chefen har förnamn,
//efternamn, e-postadress och telefonnummer.Skriv ett
//program som läser informationen om företaget och
//chefen och skriver dem till konsolen
static void Ovning03()
        {
            Boss boss = new Boss(
            firstName: "Tim",
            lastName: "Cook",
            email: "tcook@apple.com",
            phonenum: "(408) 996–1010"
            );
            Company company = new Company(
                name: "Apple", 
                address: "1 Apple Park Way, Cupertino California", 
                phonenum: "800–692–7753",
               fax: "", 
               website: "https://www.apple.com/", 
               boss: boss);

            company.Print();
            company.Boss.Print();
        }

//4. Skriv ett program som läser två positiva heltal och
//skriver hur många tal p som finns mellan dem som är
//jämnt delbara med 5. Exempel: p(17, 25) = 2

        static void Ovning04()
        {
            Console.WriteLine("Type a number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Type a second number");
            int num2 = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = num1 + 1; i < num2; i++)
            {
                if (i % 5 == 0)
                {
                    count += 1;
                }
            }
            Console.WriteLine("p({0}, {1}) = {2}", num1, num2, count);
        }

        //    5. Skriv ett program som läser två tal från konsolen och
        //skriver det största av dem.Gör det utan att använda en
        //if-sats

        static void Ovning05()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1 > num2 ? num1 : num2);
        }

        //6. Skriv ett program som läser in koefficienterna a, b och
        //c för en andragradsekvation ax2+bx+c=0 och löser den
        //(dvs skriver ut dess reella rötter)
        //Tips: https://sv.wikipedia.org/wiki/Andragradsekvation

        static void Ovning06()
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            //float x = float.Parse(Console.ReadLine());

            //float andragrad = a * x * x + b * x + c;

            float x1 = -(b / 2f) + (float)Math.Sqrt((b / 2f) * (b / 2f) - (c));
            float x2 = -(b / 2f) - (float)Math.Sqrt((b / 2f) * (b / 2f) - (c));

            Console.WriteLine("x1 = " + x1.ToString());
            Console.WriteLine("x2 = " + x2.ToString());
        }
    }



//7. Skriv ett program som läser in ett tal n.Sedan läser det
//in yttrligare n tal och beräknar och skriver deras
//summa.
//8. Skriv ett program som läser in ett heltal n och skriver
//ut alla heltal i intervallet[1..n], vart och ett på en egen
//rad

}
