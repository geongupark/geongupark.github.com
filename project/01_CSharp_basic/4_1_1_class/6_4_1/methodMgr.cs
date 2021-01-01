using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _6_4_1
{
  class methodMgr
  {
    delegate int? MyDivide(int a, int b);
    public void Run()
    {
      anonymous_Method();
      extension_Method();
    }
    private void anonymous_Method()
    {
      Console.WriteLine($"\n<< {MethodBase.GetCurrentMethod().Name} >>");
      // 익명 메소드 사용 방법
      MyDivide myAnonymous = delegate (int a, int b)
      {
        return a / b;
      };
      // rambda 식은 익명 메소드를 좀 더 효과적으로 표현하는 방법
      MyDivide myRambda = (a, b) => a / b;

      Console.WriteLine($"anonymous : {myAnonymous(6, 3)}");
      Console.WriteLine($"rambda : {myRambda(6, 3)}");
    }
    private void extension_Method()
    {
      Console.WriteLine($"\n<< {MethodBase.GetCurrentMethod().Name} >>");
      string str = "1122";
      Console.WriteLine($"GetWordCount : {str.GetWordCount()}");
      Console.WriteLine($"isDigit : {str.isDigit()}");
      Console.WriteLine($"ConverToInt : {str.ConvertToInt()}");
    }
  }

  static class ExtensionClass
  {
    public static int GetWordCount(this string str)
    {
      return str.Split().Length;
    }
    public static bool isDigit(this string str)
    {
      try
      {
        int.Parse(str);
        return true;
      }
      catch
      {
        return false;
      }
    }
    public static int? ConvertToInt(this string str)
    {
      int tmp;
      if (int.TryParse(str, out tmp)) return tmp;
      return null;
    }
  }

}
