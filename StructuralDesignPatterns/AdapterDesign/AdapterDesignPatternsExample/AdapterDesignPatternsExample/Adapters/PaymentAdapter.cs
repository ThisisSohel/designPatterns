using AdapterDesignPatternsExample.Classes;
using AdapterDesignPatternsExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPatternsExample.Adapters
{
    public class PaymentAdapter : INewPaymentGateway
    {
        private readonly OldBankAPI _oldBankAPI;

        public PaymentAdapter(OldBankAPI oldBankAPI)
        {
            _oldBankAPI = oldBankAPI;
        }

        public void MakePayment(decimal amount)
        {
            Console.WriteLine("Adapter converting request for OldBankAPI...");
            _oldBankAPI.ProcessBankPayment("123456789", amount);
        }
    }
}
