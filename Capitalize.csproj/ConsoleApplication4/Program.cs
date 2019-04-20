using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInput= Console.ReadLine();
            Console.WriteLine(Calculate(userInput));
            Console.ReadLine();
        }

        public static double Calculate (string userInput)
        {
            var parts = userInput.Split();
            var deposit = double.Parse(parts[0]);
            var percent = ((double.Parse(parts[1]))/100)/12;
            var time = double.Parse(parts[2]);
            return deposit * Math.Pow((1+percent),time);
        }
    }
}
