using FactoryDesignPatternExample.ConcreteClasses;
using FactoryDesignPatternExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatternExample.FactoryClasses
{
    // Factory clss
    public class PaymentFactory
    {
        public static IPayment GetPayment(string type)
        {
            return type switch
            {
                "PayPal" => new PayPal(),
                "Stripe" => new Stripe(),
                _ => throw new ArgumentException("Invalid payment type")
            };
        }
    }
}
