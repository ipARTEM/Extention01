using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extention01_My;

namespace Extention01
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime currentDateTime = DateTime.Now;

            currentDateTime.Print();

            DateTime.Now.Print();

            Console.WriteLine(currentDateTime.IsDayOfWeek(DayOfWeek.Thursday));

            Student student = new Student() { FirstName = "Piter", LastName = "Falk" };

            string fullName = student.GetFullName();

        }
    }
}
