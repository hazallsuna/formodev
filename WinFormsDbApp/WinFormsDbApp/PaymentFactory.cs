using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsDbApp
{
    public class PaymentFactory
    {
        public IPaymentMethod createPaymentMethod(string className)
        {
            var fullClassName = "WinFormsDbApp" + className;
            var type = Type.GetType(fullClassName);

            if (type != null && typeof(IPaymentMethod).IsAssignableFrom(type))
            {
                return (IPaymentMethod)Activator.CreateInstance(type);
            }
            else
            {
                return new PaymentMethod(className);
            }
        }
    }
}
