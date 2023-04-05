using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace taxi
{
    public class taxi
    {
        public string DriverName { get; set; }
        public Boolean OnDuty { get; set; }
        public string NumPasssanger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);
            Console.WriteLine("On Duty : {0}", OnDuty);
            Console.WriteLine("Num Passanger : {0}", NumPasssanger);

        }

        public void PickUpPassanger()
        {
            Console.WriteLine("{0} Sedang menjemput penumpang\n", DriverName);
        }

        public void DroopOffPassanger()
        {
            Console.WriteLine("{0} Selesai mengantar penumpang\n", DriverName);
        }
    }
}


