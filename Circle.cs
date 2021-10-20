using System;
using System.Collections.Generic;
using System.Text;


namespace CircleTime
{
    class Circle
    {
        public double radius { get; set; }        

        //Got from https://www.c-sharpcorner.com/blogs/count-instances-of-the-class-using-c-sharp
        public static int count = 0;

        public Circle(double radius)
        {
            this.radius = radius;
            count = count + 1;
        }

        public double CalculateCircumference(double radius)
        {
            double circumference =Math.Round(2 * Math.PI * radius,2);
            return circumference;
        }
        public double CalculateArea(double radius)
        {
            double area =Math.Round(Math.PI * radius * radius,2);
            return area;
        }    

    }
}
