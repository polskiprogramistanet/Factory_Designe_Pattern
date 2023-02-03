using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Designe_Pattern
{
    class CreditCardFactory
    {
        public static ICreditCard GetCreditCard(string cardtype)
        {
            ICreditCard cardDetail = null;
            if (cardtype == "MoneyBack")
            {
                cardDetail = new MoneyBack();
            }
            else if (cardtype == "Titanium")
            {
                cardDetail = new Titanium();
            }
            else if (cardtype == "Platinium")
            {
                cardDetail = new Platinium();
            }
            return cardDetail;
        }
    }
}
