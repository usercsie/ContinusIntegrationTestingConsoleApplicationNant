using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContinusIntegrationTestingConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.Calculator cal = new Calculator.Calculator();
            cal.Add(1, 1);

            System.Console.WriteLine("Hello world.");          
        }

        public int Add(int a, int b)
        {
         //   return a + b;
        }        
    }
}
