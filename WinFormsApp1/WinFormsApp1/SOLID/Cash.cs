using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.SOLID
{
    public class Cash : IPaymentMethod
    {
        public string Pay(string message)
        {
            return $"Nakit ile {message} TL ödeme yapıldı.";
        }
    }
}
