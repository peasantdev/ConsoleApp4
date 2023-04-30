using System;

namespace ConsoleApp4
{
    class Program
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public void Main(int Num1, int Num2) //Instantializing 
            {
                Console.WriteLine(Num1 + 5); //Performing a math operation on an integer that was taken from user input.
                Console.WriteLine(Num2);
                Console.ReadLine(); //Sending both integers to the console to display.

                Console.WriteLine($"Num1: {Num1}, Num2: {Num2}");
                Console.ReadLine(); //Showing the parameters by name & number.
            }

    }
}
