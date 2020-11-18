// 04_if4 > Program.cs
/*
 * 실습 8-4
 * If문 실습4
 * 1. 성적과 이름, 그리고 성별을 입력받는다.
 * 2. 값에 따라 처리한다.
 * 2-1. 남성이고, 성적이 90 이상이면 "우수 장학생" 출력
 * 2-2. 남성이고, 성적이 80 이상이면 "장학생" 출력
 * 2-3. 여성이고, 성적이 90 이상이면 "해외 연수 장학생" 출력
 * 2-4. 여성이고, 성적이 80 이상이면 "국비 장학생" 출력
 * 2-5. 점수에 해당사항 없으면 "해당 없음"을 출력
 * 3. 성별 구분은 Enum으로 할 것.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_if4
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
