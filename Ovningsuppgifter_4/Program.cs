using System;
namespace Ovningsuppgifter_4
{
    class Program
    {
        static void Main(string[] args)
        {

            
            uint numberOfHolders = 1;
            Bankkonto[] accounts = new Bankkonto[numberOfHolders];

            var betalKortArray = new Betalkort[] {
                new Betalkort(utgdatum: "09/22", kortTyp: "MasterCard", nummer: 123456789012, cvc: 123, saldo: 19999.799999M ),
                new Betalkort(utgdatum: "09/23", kortTyp: "Visa", nummer: 199999999999, cvc: 321, saldo: 10000.19999M ),
                new Betalkort(utgdatum: "09/24", kortTyp: "Norweigan", nummer: 112481351012, cvc: 999, saldo: 1999M) };
            accounts[0] = new Bankkonto("Georgi Vencislavov", "BNB", 0, 0, betalKortArray);

            PrintBankAccountsInfo(accounts);
            //char hexDecimal = '\u0048';
            //int hexValueChar = hexDecimal;
            //Console.WriteLine(Convert.ToString(value: hexValueChar, toBase: 2) + " " + hexDecimal);
            //Console.WriteLine($"The char value  of hexValue {hexValueChar:X}");
            //Console.WriteLine("Hello World!");
            //string hej = "hej ";
            //string varlden = "världen!";
            //object obj = hej + varlden;
            //string concat = (string)obj;
            //Console.WriteLine(concat);
            //var myName = GetMyNameInASCIICode("Tim Toresson");
            //PrintMyNameInASCIICode(myName);
        }


        static void PrintBankAccountsInfo(Bankkonto[] accounts)
        {
            Console.WriteLine("List of bank holders:\n ");
            foreach (var konto in accounts)
            {
                Console.WriteLine("Holder's name: {0}", konto.ÄgareNamn);
                Console.WriteLine("Bank name: {0}", konto.BankNamn);
                Console.WriteLine("Balance: {0:C}", konto.Saldo);
                Console.WriteLine("IBAN: {0}", (konto.IBAN == 0 ? "none" : konto.IBAN.ToString()));
                Console.WriteLine("BIC Code: {0}", (konto.BIC == 0 ? "none" : konto.BIC.ToString()));
                for (int j = 0; j < konto.BetalkortArray.Length; j++)
                {
                    int cardIndex = j + 1;
                    Betalkort kort = konto.BetalkortArray[j];
                    PrintCreditCardInfo(kort, cardIndex);

                }
            }
           
        }
        static void PrintCreditCardInfo(Betalkort kort, int cardIndex)
        {
            Console.WriteLine($"- Credit card {cardIndex}'s type: {kort.Typ}");
            Console.WriteLine($"- Credit card {cardIndex}'s number: {kort.Kortnummer}");
            Console.WriteLine($"- Credit card {cardIndex}'s number: {kort.Utgångsdatum}");
            Console.WriteLine($"- Credit card {cardIndex}'s balance: {kort.Saldo}");
        }
            static void StringBuilderTest()
        {
            Console.WriteLine("Write a string");
            string input = Console.ReadLine();
            Console.WriteLine("Enter the char to be removed");
            int value = Convert.ToInt32(Console.ReadLine());
            string builder = input.Remove(count: 1, startIndex: value);
            Console.WriteLine("Resulting String " + builder);
        }
        static int[] GetMyNameInASCIICode(string name)
        {
            var charArr = name.ToCharArray();
            int[] result = new int[charArr.Length];
            for (int i = 0; i < charArr.Length; i++)
            {
                result[i] = (int)charArr[i];
            }
            return result;
        }
        static void PrintMyNameInASCIICode(int[] codeArray)
        {
            foreach (var code in codeArray)
            {
                Console.Write((char)code);
            }
        }
        static void PrintASCII()
        {
            for (int i = 0; i <= 255; i++)
            {
                Console.WriteLine($"{i} = {(char)i}");
            }
        }
        static void SwapVariables()
        {
            int a = 5;
            int b = 10;
            int temp = a;
            a = b;
            b = temp;       
        }
    }

    class Worker
    {
        public string FirstName;
        public string SurName;
        public DateTime BirthDate;
        private ulong workerID;

        public ulong WorkerID
        {
            get { return workerID; }
            set 
            { 
                if (value >= 27560000UL && value <= 27569999UL) 
                    workerID = value; 
            }
        }
    }
}
