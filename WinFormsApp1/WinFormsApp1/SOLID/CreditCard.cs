using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.SOLID
{
    public class CreditCard : IPaymentMethod
    {
        public string Pay(string message)
        {
            return $"Kredi Kartı ile {message} TL ödeme yapıldı.";
        }
    }
}