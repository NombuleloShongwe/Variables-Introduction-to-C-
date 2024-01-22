using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            string name = "Busisiwe";
            int age;

            //initialization
            name = "Busisiwe";
            age = 12;

            //what will be seen on console
            Console.WriteLine(" There was once a girl called " + name);
            Console.WriteLine(name + " was " + age + " years of age ");
            Console.WriteLine(name + " really never liked her name ");

            //change variable values
            age = 16;
            name = "Candy";

            Console.WriteLine(" At age " + age + " she changed her name to " + name);

            //to freeze the console
            Console.ReadLine();

            /*Notes: you can also declare and initialize on the same line
             * eg 
             * string name = "Busisiwe";
             */
         }
    }
}
