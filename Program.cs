using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TugasTaxiDriver
{
    public class program
    {
        static void Main(string[] ags)
        {
            TugasTaxiDriver taxi = new TugasTaxiDriver();

            taxi.DriverName = "Jono";
            taxi.OnDuty = true;
            taxi.NumPassanger = "10";

            taxi.TaxiInfo();
            taxi.PickUpPassanger();
            taxi.DropOffPassanger();

            Console.ReadKey();
        }
    }
}
