using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsDbApp
{
    public class PaymentMethod : IPaymentMethod
    {
        private readonly string _methodName;

        public PaymentMethod(string methodName)
        {
            _methodName = methodName;
        }

        public string Pay(string message)
        {
            return $"{_methodName} ile {message} TL ödeme yapıldı.";
        }
    }
}
