/* program.cs
 * 실습 8-7 구구단 출력
 * 1) 기본 틀 구성해요. (tableMgr.cs 생성 및 Run method 정의)
 * 2) TimesTable.cs 생성 및 property 및 생성자 선언, 구구단 계산하는 printBase method 정의.
 * 3) for문을 통해 구구단 출력
 *  
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_for1
{
  class Program
  {
    static void Main(string[] args)
    {
      tableMgr tm = new tableMgr();
      tm.Run();
    }
  }
}
