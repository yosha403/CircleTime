using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CircleTime
{
    public class CricleTest
    {
        [Theory]
        [InlineData(5, 78.54)]
        [InlineData(3, 28.27)]
        [InlineData(2, 12.57)]
        public void TestCircleArea(double radius, double expected)
        {
            Circle c = new Circle();

            double actual = c.CalculateArea(radius);

            Assert.Equal(expected, actual); 
        }

        [Theory]
        [InlineData(5, 31.4)]
        [InlineData(3, 18.8)]
        [InlineData(2, 12.6)]


        public void TestCircleCircumference(double radius, double expected)
        {
            Circle c = new Circle();

            double actual = c.CalculateCircumference(radius);

            Assert.Equal(expected, actual); 
        }


    }
}
