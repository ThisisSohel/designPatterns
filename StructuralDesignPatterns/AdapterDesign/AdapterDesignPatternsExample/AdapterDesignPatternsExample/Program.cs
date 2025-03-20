using AdapterDesignPatternsExample.Adapters;
using AdapterDesignPatternsExample.Classes;
using AdapterDesignPatternsExample.Interfaces;

namespace AdapterDesignPatternsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            USBTypeACharger oldCharger = new USBTypeACharger();
            IUSBTypeC adapter = new USBAdapter(oldCharger);

            adapter.ChargeWithUSBTypeC();
        }
    }
}
