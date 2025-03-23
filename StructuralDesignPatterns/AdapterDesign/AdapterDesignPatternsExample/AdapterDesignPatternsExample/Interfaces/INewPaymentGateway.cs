using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPatternsExample.Interfaces
{
    public interface INewPaymentGateway
    {
        void MakePayment(decimal amount);
    }
}
