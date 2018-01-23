using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double Length, Width, Height, Area, Volume, Perimeter;
            char userContinue;
            bool doAgain = true;

            while (doAgain == true)
            {
                Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!");

                Console.WriteLine("Please enter the room's width");
                Width = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the room's length");
                Length = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the room's height");
                Height = double.Parse(Console.ReadLine());

                //processing
                Area = Length * Width;
                Volume = Length * Width * Height;
                Perimeter = Length * 2 + Width * 2;

                //output
                Console.WriteLine();
                Console.WriteLine($"Area: {Area} sq ft");
                Console.WriteLine($"Volume: {Volume} cu ft");
                Console.WriteLine($"Perimeter: {Perimeter} ft");
                Console.WriteLine();

                Console.WriteLine("Would you like to continue? (Y/N)");

                //input -- to run program again or not
                userContinue = char.Parse(Console.ReadLine());

                switch (userContinue)
                {
                    case 'n':
                        Console.WriteLine("Goodbye!");
                        System.Threading.Thread.Sleep(1000);
                        doAgain = false;
                        break;
                    case 'N':
                        Console.WriteLine("Goodbye!");
                        System.Threading.Thread.Sleep(1000);
                        doAgain = false;
                        break;
                    case 'y':
                        Console.WriteLine("Ok, here we go!");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine();
                        break;
                    case 'Y':
                        Console.WriteLine("Ok, here we go!");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine();
                        break;
                }
            }

        }
    }
}
