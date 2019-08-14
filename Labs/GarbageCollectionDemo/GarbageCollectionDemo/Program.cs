using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Calculator calculator = new Calculator())                       //Important: This is the format you
            {                                                                      // want to use when needing to close
                Console.WriteLine($"120 / 0 = {calculator.Divide(120, 0)}");       //The using statement is a habit you
            } //This fires off the Dispose()                                       // need to develop
            //Calculator calculator = new Calculator();
            //Console.WriteLine($"120 / 15 = {calculator.Divide(120, 15)}");
            Console.WriteLine("Program finishing");
        }
    }
}
