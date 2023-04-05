using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace taxi
{
    public class program
    {
        static void Main(string[] args)
        {
            taxi  taxi= new taxi();

            taxi.DriverName = "Jono";
            taxi.OnDuty = true;
            taxi.NumPasssanger = "10";

            taxi.TaxiInfo();
            taxi.PickUpPassanger();
            taxi.DroopOffPassanger();

            Console.ReadKey();
        }
    }
}

