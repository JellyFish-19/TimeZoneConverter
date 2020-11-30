using System;
using TimeZoneConverter; //using TimeZoneConverter library 

namespace TestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeZoneInfo localZone = TimeZoneInfo.Local; //Getting general information about the local time zone.

            Console.WriteLine("General timezone info: ");
            Console.WriteLine("Standard name is: {0}.", localZone.StandardName);
            Console.WriteLine("Display name is: {0}.", localZone.DisplayName);

            while (true)
            {
                string localDisplay = localZone.StandardName;
                string olsonDisplay = TZConvert.WindowsToIana(localDisplay); //Converting the local Windows timezone into Olson time zone.
                string windowsDisplay = TZConvert.IanaToWindows(olsonDisplay); //Taking the converted Olson time zone, and converting it back to Windows time zone display.

                //Converting between Olson time zone and Windows time zone with any key, unless esc is pressed

                Console.WriteLine("\nPress any key to convert to Olson timezone or esc to exit");

                if (Console.ReadKey().Key != ConsoleKey.Escape)
                {
                    PrintOlsonTimeZone(olsonDisplay);
                } 
                else
                {
                    break;
                }

                Console.WriteLine("\nPress any key to convert to Windows timezone or esc to exit");

                if (Console.ReadKey().Key != ConsoleKey.Escape)
                {
                    PrintWindowsTimeZone(windowsDisplay);
                }
                else
                {
                    break;
                }
            } 
        }

        static void PrintOlsonTimeZone(string olsonDisplay)
        {
            Console.Clear();
            Console.WriteLine("Olson timezone info: ");
            Console.WriteLine("Standard name is: {0}.", olsonDisplay);
        }

        static void PrintWindowsTimeZone(string windowsDisplay)
        {
            Console.Clear();
            Console.WriteLine("Windows timezone info: ");
            Console.WriteLine("Standard name is: {0}.", windowsDisplay);
        }
    }
}
