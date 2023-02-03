using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Designe_Pattern
{
    class Platinium : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 2000;
        }

        public string GetCardType()
        {
            return "Platinium";
        }

        public int GetCreditLimit()
        {
            return 35000;
        }
    }
}
