using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Designe_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
             
            ICreditCard cardDetail = CreditCardFactory.GetCreditCard("Titanium");

            if (cardDetail != null)
            {
                Console.WriteLine("Card type {0}", cardDetail.GetCardType());
                Console.WriteLine("Credit limit: {0}", cardDetail.GetCreditLimit());
                Console.WriteLine("Annual Charge {0}", cardDetail.GetAnnualCharge());
            }
            else
            {
                Console.WriteLine("Brak typu karty");
            }

            Console.ReadLine();
        }
    }
}
