using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            //Console.Read();
            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Please enter your age: ");
            string userAge = Console.ReadLine();
            Console.WriteLine("Please enter the current year: ");
            string currentYear = Console.ReadLine();
            int yearBorn = Convert.ToInt32(currentYear);
            int userAge2 = Convert.ToInt32(userAge);
            yearBorn = yearBorn - userAge2;
            Console.WriteLine("Hello World! My name is " + userName + " and I am " + userAge + " years old. I was born in " + yearBorn + ".");
            Console.ReadLine();
        }
    }
}
