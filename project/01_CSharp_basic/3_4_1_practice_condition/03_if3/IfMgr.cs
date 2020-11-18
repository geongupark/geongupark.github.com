// IfMgr.cs
/*
 * 1. Project 생성 후 시작 프로젝트 설정 및 MyLibrary를 참조해줘요.
 * 2. 특정 범위(min~max)의 숫자를 입력받기 위해 MyUtil class 내의 GetDigit 메소드를 오버로딩 해줘요.
 * 3. 입력된 점수를 판단해주는 EvalScore 메소드를 구현해줘요.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace _03_if3
{
  class IfMgr
  {
    public void Run()
    {
      // 주 실행 흐름
      EvalScore(MyUtil.GetDigit(0, 100));
    }  
    private void EvalScore(int v)
    {
      if (v == -2)
        Console.WriteLine("성적이 범위를 초과하였습니다.");
      else if (v == -1)
        Console.WriteLine("성적에 숫자가 아닌 문자가 있어요.");
      else if (v > 90)
        Console.WriteLine("A");
      else if (v > 80)
        Console.WriteLine("B");
      else if (v > 70)
        Console.WriteLine("C");
      else if (v > 60)
        Console.WriteLine("D");
      else
        Console.WriteLine("F");
    }
  }
}
