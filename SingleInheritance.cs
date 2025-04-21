using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1.task1
{
    class Furniture
    {
        string material="wood";
        double price=3000;

        void displayFurnitureDetails()
        {
            Console.WriteLine("material:" + material);
            Console.WriteLine("price:" + price);

        }
    }

    class Table:Furniture
    {
        double height;
        string surfaceType;

    }
    internal class SingleInheritance
    {
        static void Main(string[] arg)
        {
            Table t = new Table();
            
        }
    }
}
