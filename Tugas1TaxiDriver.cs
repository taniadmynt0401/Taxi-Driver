using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasTaxiDriver
{
    public class TugasTaxiDriver
    {
        public string DriverName { get; set; }
        public Boolean OnDuty { get; set; }
        public string NumPassanger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);
            Console.WriteLine("On Duty : {0}", OnDuty);
            Console.WriteLine("Num Passanger : {0}", NumPassanger);

        }
        public void PickUpPassanger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang\n", DriverName);

        }

        public void DropOffPassanger()

        {
            Console.WriteLine("{0} selesai mengantar penumpang\n", DriverName);
        }
    }
}
