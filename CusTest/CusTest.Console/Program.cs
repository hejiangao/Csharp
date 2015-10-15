using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CusTest.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            System.Console.WriteLine("请输入...");
            input = System.Console.ReadLine();
            System.Console.WriteLine("您输入的内容是：");
            System.Console.WriteLine(input);
            System.Console.ReadKey();
        }
    }
}
