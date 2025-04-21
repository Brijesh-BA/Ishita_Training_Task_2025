using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1.task1
{
    class Salary
    {
        int basic;
        int TA;
        int DA=2500;
        int HRA=1200;

        Salary(int basic, int TA)
        {
            this.basic = basic;
            this.TA = TA;
        }
        

        void calculateSalary()
        {
            double grossSalary = basic + TA + DA + HRA;
            Console.WriteLine("Gross Salary is:" + grossSalary);
        }

        static void Main(string[] args)
        {
            Salary s = new Salary(10000,2500);
            s.calculateSalary();
        }
    }
}
