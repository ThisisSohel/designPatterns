using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPatternsExample.Classes
{
    public class OldBankAPI
    {
        public void ProcessBankPayment(string accountNumber, decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount} using OldBankAPI for account {accountNumber}");
        }
    }
}
