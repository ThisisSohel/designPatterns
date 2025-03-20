using FactoryDesignPatternExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatternExample.ConcreteClasses
{
    // Concrete Class
    public class PayPal : IPayment
    {
        public void ProcessPayment() => Console.WriteLine("Processing via PayPal");
    }
}
