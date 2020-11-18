/*
 * If문 실습2
 * 1. 숫자를 하나 받음
 * 2. 숫자가 90보다 크면 "우수", "수고하셨습니다" 출력
 * 3. 숫자가 90미만이면 "보통", "좀 더 노력하세요" 출력
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_If2
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