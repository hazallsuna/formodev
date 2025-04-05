using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.SOLID
{
    public class Payment
    {
        public IPaymentMethod paymentMethod;

        public Payment(IPaymentMethod paymentMethod)
        {
            this.paymentMethod = paymentMethod;
        }

        public string Pay(string message)
        {
            return paymentMethod.Pay(message).ToString();
        }
    }
}