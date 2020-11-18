using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_if1
{
  public class IfMgr
  {
    public void Run()
    {
      // 주 실행 흐름
      PrintResult(GetDigit());
    }

    private void PrintResult(int val)
    {
      if (val < 0 || val > 100)
      {
        Console.WriteLine("Error: 숫자가 아니거나 범위를 벗어남");
      }
      else if (val > 90)
      {
        Console.WriteLine("우수");
        Console.WriteLine("수고하셨습니다.");
      }
    }

    private int GetDigit()
    {
      Console.WriteLine("숫자를 입력하쇼[0~100] : ");
      return ConvertString2Int(Console.ReadLine());
    }

    private int ConvertString2Int(string str)
    {
      int result = 0;
      bool ret = int.TryParse(str, out result);
      if (ret)
        return result;
      else
        return -1;  // error
    }
  }

}
