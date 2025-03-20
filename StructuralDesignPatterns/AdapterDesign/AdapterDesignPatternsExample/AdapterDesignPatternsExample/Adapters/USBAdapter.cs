using AdapterDesignPatternsExample.Classes;
using AdapterDesignPatternsExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPatternsExample.Adapters
{
    public class USBAdapter : IUSBTypeC
    {
        private USBTypeACharger _usbACharger;

        public USBAdapter(USBTypeACharger usbACharger)
        {
            _usbACharger = usbACharger;
        }

        public void ChargeWithUSBTypeC()
        {
            Console.WriteLine("Adapter converts USB-A to USB-C...");
            _usbACharger.ChargeWithUSBTypeA();
        }
    }
 
}
