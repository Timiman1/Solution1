using System;
using System.Collections;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ovningsuppgifter05
{




    class Program
    {
        static void Main(string[] args)
        {
            //PrintIsNumberEvenOrOdd(1);
            //PrintIsNumberDivisibleBy5And7(35);
            //PrintAreaOfRect(width: 15.3, height: 7.8);
            //Ovning04(766);
            //Ovning05(3444);
            //PrintIsPointInsideCircle(point_x: 3, point_y: 6);
            //PrintPrime(22);
            //PrintIsPointInsideCircleAndRect(2, 2);
            //Ovning10(0b_1001_1111, 7);
            //Ovning11(5999, 3);
            //Ovning12(55, 1, 3);
            //Ovning13();
        }

        //    1. Skriv ett uttryck som kollar om ett givet heltal är udda eller jämnt
        static void PrintIsNumberEvenOrOdd(int num)
        {
            if (num % 2 == 0)
                Console.WriteLine($"{num} = Even number");
            else
                Console.WriteLine($"{num} = Odd number");

        }
        //2. Skriv ett booleskt uttryck som kollar om ett givet heltal är jämnt
        //delbart med 5 och 7 samtidigt
        static void PrintIsNumberDivisibleBy5And7(int num)
        {
            if (num % 5 == 0 && num % 7 == 0)
                Console.WriteLine($"{num} is divisable by 5 and 7");
            else
                Console.WriteLine($"{num} is not divisable by 5 and 7");

        }
        //3. Skriv ett uttryck som beräknar arean av en rektangel utifrån inmatade
        //width och height
        static void PrintAreaOfRect(double width, double height)
        {
            double area = width * height;
            Console.WriteLine($"Area of rectangle (width: {width} height: {height}) = {area}");
        }

        //4. Skriv ett uttryck som kontrollerar ett givet heltal för att se om dess
        //tredje värdesiffra(dvs tredje siffran från höger) är 7. T.ex. 1732 ➔
        //true.
        static void Ovning04(int num)
        {          
            if (Math.Abs(num) < 100)
            {
                Console.WriteLine($"{num} == 7 is false");
                return;
            }
            string str = num.ToString();
            bool isSeven = Convert.ToInt32(str.Substring(str.Length - 3, 1)) == 7;
            Console.WriteLine($"Third digit from right in {num} == 7 is {isSeven}");
        }

        //5. Skriv ett booleskt uttryck som kontrollerar om bit 3 (räknat från 0
        //längst till höger) av ett givet heltal är 1 eller 0.
        static void Ovning05(uint bitWiseNum)
        {
            string str = Convert.ToString(bitWiseNum, toBase: 2);
            if ((bitWiseNum & 0b_1000) == 0b_0000)
            {
                Console.WriteLine($"Bit 3 of {str} equals 0");
            }
            else
            {
                Console.WriteLine($"Bit 3 of {str} equals 1");
            }
        }

//        6. Skriv ett uttryck som kontrollerar om en given punkt(x, y) ligger inom
//en cirkel K((0, 0), 5) (dvs cirkel med centrum i(0, 0) och radien 5)

        static void PrintIsPointInsideCircle(uint point_x, uint point_y)
        {
            uint circle_x = 0;
            uint circle_y = 0;
            uint radius = 5;
            int distance_x = (int)Math.Abs(point_x - circle_x);
            int distance_y = (int)Math.Abs(point_y - circle_y);
            if (distance_x > radius || distance_y > radius)
            {
                Console.WriteLine($"Point ({point_x}, {point_y}) is outside of circle K((0, 0), 5)");
            }
            else
            {
                Console.WriteLine($"Point ({point_x}, {point_y}) is inside of circle K((0, 0), 5)");
            }

        }

//7. Skriv ett uttryck som kontrollerar om ett givet positivt heltal n(n≤100)
//är ett primtal.Till exempel är 37 ett primtal.
static void PrintPrime(uint num)
        {
            int divs;
            divs = 0;
            if (num > 100)
            {
                throw new ArgumentOutOfRangeException($"Number out of range ({num}>100)");
            }
            // Check if num can be evenly divided 1 and any number below num/2 => Not a prime number
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    divs++;
                }
            }
            if (divs == 1)
            {
                Console.WriteLine($"{num} is a Prime Number and the Largest Factor is {num}");
            }
            else
            {
                Console.WriteLine($"{num} is not a Prime Number");
            }
        }
//8. Skriv ett uttryck som beräknar arean på en paralelltrapets givet
//sidorna a och b samt höjden h.
// A = (a + b) / 2 * h

        static void PrintTrapezoidArea(double a, double b, double h)
        {
            double area = Math.Abs(((a + b) / 2) * h);
            Console.WriteLine($"Trapezoid ({a}, {b}, {h}) Area = {area}");
        }
        //9. Skriv ett uttryck som kontrollerar om en given punkt (x, y) ligger
        //innanför cirkeln K((1, 1), 3) och utanför rektangeln R(top= 1, left= -1,
        //width= 6, height= 2)
        static void PrintIsPointInsideCircleAndRect(uint point_x, uint point_y)
        {
            double circle_x = 0;
            double circle_y = 0;
            double radius = 5;
            double rect_top = 1;
            double rect_left = -1;
            double rect_width = 6;
            double rect_height = 2;
            double rect_bottom = rect_top + rect_height;
            double rect_right = rect_left + rect_width;
            double circle_distance_x = Math.Abs(point_x - circle_x);
            double circle_distance_y = Math.Abs(point_y - circle_y);           
            if (circle_distance_x > radius || circle_distance_y > radius)
            {
                Console.WriteLine($"Point ({point_x}, {point_y}) is outside of circle K((0, 0), 5)");
            }
            else
            {
                Console.WriteLine($"Point ({point_x}, {point_y}) is inside of circle K((0, 0), 5)");
            }
            if (point_x >= rect_left && point_x <= rect_right && point_y >= rect_top && point_y <= rect_bottom)
            {
                Console.WriteLine($"Point ({point_x}, {point_y}) is inside of rectangle R(top = 1, left = -1, width = 6, height = 2)");
            }
            else
            {
                Console.WriteLine($"Point ({point_x}, {point_y}) is outside of rectangle R(top = 1, left = -1, width = 6, height = 2)");
            }

        }

//        10. Skriv ett booleskt uttryck som returnerar sant om biten vid position p
//(räknat från 0) i ettgivet heltal v har värdet 1. Exempel: v=5;p=1

        static void Ovning10(uint v, uint p)
        {
            string str = Convert.ToString(v, toBase: 2);
            char[] charArr = str.ToCharArray();
            try
            {
                if (charArr[charArr.Length - p - 1] == '1')
                {
                    Console.WriteLine($"Bit by position {p} of binary value {str} equals true");
                }
                else
                {
                    Console.WriteLine($"Bit by position {p} of binary value {str} equals false");
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Index out of bounds of array", e);
            }
        }
        //➔false
        //11. Skriv ett uttryck som extraherar från ett givet heltal i värdet av en
        //given bit nummer b.Exempel: i=5;b=2 ➔ value=1
        static void Ovning11(uint i, uint b)
        {
            //var test = new BitArray(new int[] { (int)i });
            //Console.WriteLine("OVNING11");
            //for (int j = test.Count - 1; j >= 0; j--)
            //{
            //    Console.Write(test[j] ? "1" : "0");
            //}
            
            
            string str = Convert.ToString(i, toBase: 2);
            char[] charArr = str.ToCharArray();
            try
            {
                if (charArr[charArr.Length - b - 1] == '1')
                {
                    Console.WriteLine($"Bit by position {b} of binary value {str} equals 1");
                }
                else
                {
                    Console.WriteLine($"Bit by position {b} of binary value {str} equals 0");
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Index out of bounds of array", e);
            }
        }
        //12. Vi har ett heltal n, värde v(v= 0 eller 1) och en position p.Skriv en
        //sekvens av operationer som modifierar n så att biten vid position p får
        //värdet v.
        static void Ovning12(uint n, uint v, uint p)
        {
            if (v != 0 && v != 1) 
                return;

            string binString = Convert.ToString(n, toBase: 2);
            char[] charArr = binString.ToCharArray();
            try
            {
                charArr[charArr.Length - p - 1] = (v == 0) ? '0' : '1';
                string newBinString = new string(charArr);
                Console.WriteLine($"Before conversion: n = {n} ({binString})");
                Console.WriteLine($"After conversion: n = {Convert.ToInt32(newBinString, fromBase: 2)} ({newBinString})");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Index out of bounds of array", e);
            }
        }

        //Exempel: n= 5(00000101), p= 3, v= 1 ➔13 (00001101)
        //n=5(00000101), p=2, v=0 ➔1 (00000001)

        //        13. Skriv ett program som byter bitarna 3, 4 och 5 mot bitarna 24, 25 och
        //26 för ett givet 32-bitars unsigned heltal.
        static void Ovning13()
        {
            int index1 = 3, index2= 4, index3 = 5, index4 = 24, index5 = 25, index6 = 26;
            Console.WriteLine("Type a number");
            var bitArray = new BitArray(new int[] { int.Parse(Console.ReadLine()) });
            for (int i = bitArray.Length - 1; i >= 0; i--)
            {
                Console.Write(Convert.ToInt32(bitArray[i]));
            }
            Console.WriteLine("");
            bool temp1 = bitArray[index1], temp2 = bitArray[index2], temp3 = bitArray[index3];
            bitArray[index1] = bitArray[index4];
            bitArray[index2] = bitArray[index5];
            bitArray[index3] = bitArray[index6];
            bitArray[index4] = temp1;
            bitArray[index5] = temp2;
            bitArray[index6] = temp3;
            for (int i = bitArray.Length - 1; i >= 0; i--)
            {
                Console.Write(Convert.ToInt32(bitArray[i]));
            }
            
            
        }

        //14. * Skriv ett program som byter ut bitarna {p, p+1, …, p+k-1}
        //    mot
        //bitarna
        //    { q, q+1, …, q+k-1}
        //    på ett givet 32-bits unsigned heltal.
    }
}
