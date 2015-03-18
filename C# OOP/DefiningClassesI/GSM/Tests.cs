using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
    class Tests
    {
        static void Main()
        {
            GSMTest();
            GSMCallHistoryTest();
        }

        private static void GSMTest()
        {
            GSM test1 = new GSM(Manufacturer.LG, "G3", 450.00m, "John",
            new Battery(BatteryType.Li_Ion, 2700, 40, 15), new Display(DisplayType.TrueHD_IPS_Plus_LCD, 5.5, 5), OS.ANDROID);

            GSM test2 = new GSM(Manufacturer.SAMSUNG, "S5", 500.00m, "Mike",
             new Battery(BatteryType.Li_Ion, 2600, 40, 15), new Display(DisplayType.HD_Super_AMOLED, 5.0, 5), OS.ANDROID);

            GSM test3 = new GSM(Manufacturer.APPLE, "iPhone 6 Plus", 600.00m, "Smith",
            new Battery(BatteryType.Li_Ion, 2900, 30, 10), new Display(DisplayType.IPS_LCD, 6.0, 5), OS.IOS);

            GSM[] allPhones = { test1, test2, test3 };
            Console.WriteLine("GSM TEST:");
            foreach (var gsm in allPhones)
            {
                Console.WriteLine(gsm);
            }
            Console.WriteLine(GSM.LG_G3);
        }

        private static void GSMCallHistoryTest()
        {
            GSM myGSM = new GSM(Manufacturer.LG, "G3", 450.00m);
            myGSM.AddCall(new Call(new DateTime(2015, 03, 17, 15, 30, 30), new ContactInfo("Emelinkoo", "+359 882 232 233"), 377));
            myGSM.AddCall(new Call(new DateTime(2015, 03, 16, 11, 25, 11), new ContactInfo("Tisho", "+359 724 232 876"), 400));
            myGSM.AddCall(new Call(new DateTime(2015, 03, 16, 22, 10, 10), new ContactInfo("Yanko", "+359 324 235 233"), 200));
            myGSM.AddCall(new Call(new DateTime(2015, 03, 14, 23, 59, 00), new ContactInfo("Boci", "+359 882 232 233"), 155));
            myGSM.AddCall(new Call(new DateTime(2015, 03, 13, 02, 55, 44), new ContactInfo("Stef", "+359 123 672 244"), 344));

            myGSM.DisplayCallHistory();

            Console.WriteLine("Total calls price: {0:F2} levs.", myGSM.CalculateCallPrice(0.37m));

            myGSM.DeleteCall(2);
            Console.WriteLine("Longest call was removed.");

            myGSM.CallHistory.Clear();
            Console.WriteLine("Call history was cleared.");
        }
    }
}
