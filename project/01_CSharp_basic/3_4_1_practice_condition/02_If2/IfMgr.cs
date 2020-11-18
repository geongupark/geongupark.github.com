using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace _02_If2
{
  public class IfMgr
  {
    public void Run()
    {
      // 주 실행 흐름
      PrintResult(MyUtil.GetDigit());
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
      else
      {
        Console.WriteLine("보통");
        Console.WriteLine("좀 더 노력하세요.");
      }
    }
  }

}
