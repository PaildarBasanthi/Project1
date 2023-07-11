using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstname;
            string lastname;
            Console.WriteLine("Enter first name");
            firstname = Console.ReadLine();
            Console.WriteLine("enter last name");
            lastname = Console.ReadLine();
            Console.WriteLine("Welcome mr.\\ms.  " + firstname + " " + lastname);
            Console.ReadKey();
            //Example3
            string name;
            int age;
            char grade;
            DateTime doj;
            double salary;
            Console.WriteLine("enter Name");
            name = Console.ReadLine();
            Console.WriteLine("enter age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("enter grade");
            grade = char.Parse(Console.ReadLine());
            Console.WriteLine("enter date of joining");
            doj = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("enter salary");
            salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Name : \t" + name + "\n Age: " + age + "\n Grade: \t" + grade + "\n Salary: \t " + salary + "\n Date of Joining: \t " + doj);
            Console.ReadKey();

        }
    }
}
