using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsDbApp
{
    public interface IPaymentMethod
    {
        string Pay(string message);
    }
}
