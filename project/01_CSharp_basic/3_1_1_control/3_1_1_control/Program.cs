using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1_1_control
{
  class Program
  {
    static void Main(string[] args)
    {
      int a;
      string val = Console.ReadLine();

      a = int.Parse(val);

      Console.WriteLine("Your choice : " + a);

      #region If문
      Console.WriteLine("If문");
      if (a == 1)
      {
        Console.WriteLine("one: " + a);
      }
      else if (a == 2)
      {
        Console.WriteLine("two : " + a);
      }
      else
      {
        Console.WriteLine("others : " + a);
      }
      #endregion
      #region switch문
      Console.WriteLine("switch 문");
      switch (a)
      {
        case 1:
          Console.WriteLine("one : " + a);
          break;
        case 2:
          Console.WriteLine("two : " + a);
          break;
        default:
          Console.WriteLine("others : " + a);
          break;
      }
      #endregion
    }
  }
}
