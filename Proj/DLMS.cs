using System;

namespace DLMSConnection
{
    public class DLMS
    {
        // Main method
        public static void Main(string[] args)
        {
            // Defining instances
            Logical_Name LN = new Logical_Name();
            Clock CLK = new Clock();
            Logical_Name_Simulator LNSIM = new Logical_Name_Simulator();
            Clock_Simulator CLKSIM = new Clock_Simulator();

            // Display the available options.
            Console.WriteLine("DLMS Meter Parameters:");
            Console.WriteLine("1. Logical Name");
            Console.WriteLine("2. Clock");
            Console.WriteLine("DLMS Meter Parameters Simulator:");
            Console.WriteLine("3. Logical Name Simulator");
            Console.WriteLine("4. Clock Simulator");
            Console.WriteLine();

            // Get the user's choice.
            Console.Write("Choose an Option to Execute: ");
            string input = Console.ReadLine();

            // Process the user's choice.
            switch (input)
            {
                case "1":
                    Console.WriteLine("\nReading Logical Name Instructions Executing.\n");
                    Logical_Name.logicalName();
                    Console.WriteLine("\nReading Logical Name Instructions End.");
                    break;

                case "2":
                    Console.WriteLine("\nReading Clock Instructions Executing.\n");
                    Clock.clock();
                    Console.WriteLine("\nReading Clock Instructions End.");
                    break;

                case "3":
                    Console.WriteLine("\nLogical Name Simulator Executing.\n");
                    Logical_Name_Simulator.LogicalNameSimulator();
                    Console.WriteLine("\nLogical Name Simulator End.");
                    break;

                case "4":
                    Console.WriteLine("\nClock Simulator Executing.\n");
                    Clock_Simulator.ClockSimulator();
                    Console.WriteLine("\nClock Simulator End.");
                    break;

                default:
                    Console.WriteLine("\nINVALID INPUT!!!");
                    break;
            }

            // Wait for user to press a key before closing console window
            Console.ReadKey();
        }
    }
}