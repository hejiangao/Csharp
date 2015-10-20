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
            //测试一个静态成员
            //泛型类的静态成员只能在类的一个实例中共享。
            StaticDemo<string>.x = 4;
            StaticDemo<int>.x = 5;
            System.Console.WriteLine("sring:" + StaticDemo<string>.x);
            System.Console.WriteLine("int:" + StaticDemo<int>.x);
            StaticDemo<string>.x = 6;
            System.Console.WriteLine("sring:" + StaticDemo<string>.x);
            //控制台输入
            string input = string.Empty;
            System.Console.WriteLine("请输入...");
            input = System.Console.ReadLine();
            System.Console.WriteLine("您输入的内容是：");
            System.Console.WriteLine(input);
            System.Console.ReadKey();
        }
    }
}
