using System;
using System.Collections.Generic;

//DevBuild Lab : CIRCLE TIME
//Author: Yosha Kunnummal
//Date: 10/19/2021
namespace CircleTime
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> circleList = new List<string>();

            Console.WriteLine("Welcome to the Circle Tester");

            bool goOn = true;
            while (goOn)
            {
                Console.Write("\nEnter Radius: ");
                try
                {
                    double radius = double.Parse(Console.ReadLine());
                    Circle c = new Circle(radius);
                    
                    double circumference = c.CalculateCircumference(radius);
                    double area = c.CalculateArea(radius);
                    Console.WriteLine("Circumference: " + circumference);
                    Console.WriteLine("Area: " + area);
                    Console.WriteLine();

                    //Adding the circle radius,area,circumference to a list
                    circleList.Add(radius.ToString());
                    circleList.Add(Math.Round(area, 2).ToString());
                    circleList.Add(Math.Round(circumference, 2).ToString());
                    
                    //Printing the list
                    foreach (string circle in circleList)
                    {
                        Console.WriteLine(circle.ToString());                 
                       
                    }

                    goOn = Continue();
                }
                catch(FormatException)
                {
                    Console.WriteLine("Please enter the circle radius.");
                }
            }
        }        

        //A method to continue the application
        public static bool Continue()
        {
            Console.Write("\nContinue? (y/n): ");
            string answer = Console.ReadLine().ToLower();

            if (answer.ToLower() == "y")
            {
                return true;
            }
            else if (answer.ToLower() == "n")
            {
                Console.WriteLine($"Goodbye. You created {CircleTime.Circle.count} Circle object(s).");
                return false;
            }
            else
            {
                Console.WriteLine("\nThis is not a valid selection. ");
                Console.WriteLine("Please try again!");

                //This is recursion, calling a method inside itself
                return Continue();
            }
        }
    }
}
