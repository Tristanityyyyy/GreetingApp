using System;
namespace GreetingApp
{
    class GreetingProgram
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter the total number of your enrolled courses: ");

            int enrolledCourse;
            enrolledCourse = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the price of your favorite book: ");
            double price;
            price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Total enrolled courses: " + enrolledCourse);
            Console.WriteLine("Price of my favorite booke: " + price);

            Console.Write("\n Press any key to exit...");
            Console.ReadKey();
        }
    }
}