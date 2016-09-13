using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "saeed";
            Console.WriteLine(str.MyExtendedMethod());
        }
    }

    public static class StringExtensions
    {
        public static string MyExtendedMethod(this String str)
        {
            return "Hello i am extended Method";
        }
    }
}
