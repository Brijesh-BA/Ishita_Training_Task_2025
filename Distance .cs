using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1.task1
{
    class Distance
    {
        int dis1;
        int dis2;
        int dis3;

        Distance(int dis2, int dis3)
        {
            this.dis2 = dis2;
            this.dis3 = dis3;
        }

        void calculateDistance()
        {
            dis1 = dis2 + dis3;
            Console.WriteLine("Distance is:" + dis1);
        }

        static void Main(string[] args)
        {
            Distance d = new Distance(20, 30);
            d.calculateDistance();

        }
    }
   
}
