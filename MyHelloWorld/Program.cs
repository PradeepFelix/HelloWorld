using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SayHello());
        }
        public static string SayHello() {
            return "Hello World";
        }

    }
}
