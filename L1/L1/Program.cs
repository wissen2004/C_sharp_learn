using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int x;
            int y= 25;
        
            Console.WriteLine("y = "+ y.ToString());
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("z = " + z.ToString());

            Console.WriteLine("Write your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Write your age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello, " + name + "! Your age: " + age + " years.");
            Console.ReadKey();

        }
    }
}
