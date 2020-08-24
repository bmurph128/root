using RootInsuranceKata.Logic;
using System;
using System.Collections.Generic;
using System.IO;

namespace RootInsuranceKata
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomerFileUploadService service = new CustomerFileUploadService();
            string file = "";

            if (args.Length > 0)
            {
                file = args[0];
            }
            else
            {
                return;
            }
            List<DriverDto> driverData = service.UploadFile(file);

            foreach (DriverDto driver in driverData)
            {
                Console.WriteLine(driver.Name + ": " + driver.Miles + " miles @ " + driver.Mph + " mph");
            }

        }
    }
}
