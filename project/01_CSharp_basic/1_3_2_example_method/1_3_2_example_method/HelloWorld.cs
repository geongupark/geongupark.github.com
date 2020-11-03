// 1-3-2 example of method
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_3_2_example_method
{
  class HelloWorld
  {
    static void Main()
    {
      PrintHello();
      PrintStr("gus");
    }

    static void PrintHello()
    {
      Console.WriteLine("Hello World");
    }

    static void PrintStr(string str)
    {
      Console.WriteLine(str);
    }
  }
}
