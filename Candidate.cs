using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Candidate
    {
        int id;
        String name;
        int age;
        double weight;
        double height;

        void GetCandidateDetails()
        {
            id = 123;
            name = "john";
            age = 25;
            weight = 70.5;
            height = 175.5;
        }

        void DisplayCandidateDetails()
        {
            Console.WriteLine("Candidate id:" + id);
            Console.WriteLine("Candidate name:" + name);
            Console.WriteLine("Candidate age:" + age);
            Console.WriteLine("Candidate weight:" + weight);
            Console.WriteLine("Candidate height:" + height);



        }

        static void Main(string[] args)
        {
            Candidate c = new Candidate();
            c.GetCandidateDetails();
            c.DisplayCandidateDetails();
          
        }
    }
}
