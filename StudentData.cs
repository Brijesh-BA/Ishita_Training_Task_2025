using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1.task1
{
    class StudentData
    {
        int EnrollmentNo;
        string Name;
        string Semester;
        int CPI;
        int SPI;

        StudentData(int e_no, string name, string sem, int cpi, int spi)
        {
            EnrollmentNo = e_no;
            Name = name;
            Semester = sem;
            CPI = cpi;
            SPI = spi;
        }

        static void Main(string[] args)
        {
            StudentData s = new StudentData(123456, "john", "3rd", 8, 9);
            Console.WriteLine("Enrollnment number:" + s.EnrollmentNo);
            Console.WriteLine("Name:" + s.Name);
            Console.WriteLine("Semester:" + s.Semester);
            Console.WriteLine("CPI is:" + s.CPI);
            Console.WriteLine("SPI is :" + s.SPI);

        }
    }

   
}
