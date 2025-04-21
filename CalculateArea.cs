using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1.task1
{
    class CalculateArea
    {
        double lenght;
        double breadth;
        double area;

        CalculateArea(double l,double b)
        {
            lenght = l;
            breadth = b;
        }

        void calculateArea()
        {
            area = lenght * breadth;
            Console.WriteLine("Area of rectangle is:" + area);
        }

        static void Main(string[] arg)
        {
            CalculateArea c = new CalculateArea(10.20, 30);
            c.calculateArea();
        }
    }
}
