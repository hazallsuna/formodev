using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.SOLID
{
    public class PaymentFactory
    {
        public IPaymentMethod createPaymentMethod(string className)
        {
            var newObject = System.Reflection.Assembly.GetAssembly(typeof(IPaymentMethod)).CreateInstance("WinFormsApp1.SOLID." + className);

            return (IPaymentMethod)newObject;

        }
    }
}
