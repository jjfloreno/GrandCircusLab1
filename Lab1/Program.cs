using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Console.WriteLine($"Area: {Area}");
                Console.WriteLine($"Volume: {Volume}");
                Console.WriteLine($"Perimeter: {Perimeter}");
                Console.WriteLine();

                Console.WriteLine("Would you like to continue? (Y/N)");

                //input -- to run program again or not
                userContinue = char.Parse(Console.ReadLine());

                if(userContinue == 'N' || userContinue == 'n')
                {
                    Console.WriteLine("Goodbye!");
                    doAgain = false;
                    Console.Read();
                }
            }

        }
    }
}
