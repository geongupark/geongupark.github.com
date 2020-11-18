// Program.cs
/*
 * 실습 8-3
 * If문 실습3
 * 1. 숫자를 받아들인다.
 * 2. 숫자 범위가 0보다 작거나 100보다 크면 에러 처리한다.
 * 3. 숫자가 91~100 사이면 "A"를 출력
 * 4. 숫자가 81~90 사이면 "B"를 출력
 * 5. 숫자가 71~80 사이면 "C"를 출력
 * 6. 숫자가 61~70 사이면 "D"를 출력
 * 7. 숫자가 60 이하면 "F"를 출력
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_if3
{
  class Program
  {
    static void Main(string[] args)
    {
      IfMgr im = new IfMgr();
      im.Run();
    }
  }
}
