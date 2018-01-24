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
            double Length, Width, Height;
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

                //output
                Console.WriteLine();
                Console.WriteLine($"Area: " + GetArea(Length, Width) + " sq ft");
                Console.WriteLine($"Volume: " + GetVol(Length, Width, Height) + " cu ft");
                Console.WriteLine($"Perimeter: " + GetPerimeter(Length, Width) + " ft");
                Console.WriteLine();

                Console.WriteLine("Would you like to continue? (Y/N)");

                //input -- to run program again or not
                if (char.TryParse(Console.ReadLine(), out userContinue))
                {
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
                            Console.Clear();
                            break;
                        case 'Y':
                            Console.WriteLine("Ok, here we go!");
                            System.Threading.Thread.Sleep(1000);
                            Console.Clear();
                            break;
                    }
                }
                else //will quit with an invalid userInput
                {
                    Console.WriteLine("Not a valid input. Goodbye!");
                    Console.Read();
                    doAgain = false;
                }


            }
        }    
        //method to get area -- return double, takes 2 doubles (L & W)
        public static double GetArea(double Length, double Width)
        {
            return Length * Width;
        }
        //method to get volume -- return double, takes 3 dbls (L & W & H)
        public static double GetVol(double Length, double Width, double Height)
        {
            return Length * Width * Height;
        }
        //method to get area -- return double, takes 2 dbl (L & W)
        public static double GetPerimeter(double Length, double Width)
        {
            return Length * 2 + Width*2;
        }
    }
}
