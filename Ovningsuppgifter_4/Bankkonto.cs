using System;
using System.Collections.Generic;
using System.Text;

namespace Ovningsuppgifter_4
{
    internal class Bankkonto
    {
        internal string ÄgareNamn { get; private set; }
        private decimal saldo;
        internal decimal Saldo { get
            {
                decimal result = 0M;
                foreach (var kort in BetalkortArray)
                {
                    result += kort.Saldo;
                }
                return result;
            }
            private set { saldo = value; }
        }
        internal string BankNamn { get; private set; }
        internal int IBAN { get; private set; }
        internal int BIC { get; private set; }
        internal Betalkort[] BetalkortArray { get; private set; }

        public Bankkonto(string ägare, string banknamn, int iban, int bic, Betalkort[] betalkortArray)
        {
            ÄgareNamn = ägare;
            Saldo = saldo;
            BankNamn = banknamn;
            IBAN = iban;
            BIC = bic;
            BetalkortArray = betalkortArray;
        }
    }

    internal class Betalkort
    {
        internal string Typ;
        internal ulong Kortnummer;
        internal string Utgångsdatum;
        private int cvc;
        internal int CVC { get { return cvc; } private set { if (value >= 0 && value <= 999) cvc = value; } }
        internal decimal Saldo;

        internal Betalkort(string kortTyp, ulong nummer, string utgdatum, int cvc, decimal saldo)
        {
            Typ = kortTyp;
            Kortnummer = nummer;
            Utgångsdatum = utgdatum;
            CVC = cvc;
            Saldo = saldo;
        }

        internal void PrintInfo()
        {
           
        }
    }
}
