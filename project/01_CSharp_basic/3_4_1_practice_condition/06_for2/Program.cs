// Program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_for2
{
  class Program
  {
    static void Main(string[] args)
    {
      printValue();
    }

    private static void printValue()
    {
      for (int i = 1; i < 51; i++)
      {
        if (i % 3 == 0)
          Console.WriteLine($"i = {i}");
      }
    }
  }
}
