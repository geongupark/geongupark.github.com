// DeleMgr.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_12_1_Delegate
{
  class DeleMgr
  {
    // 1. member 변수 위치에 delegate 자료형 선언
    delegate void MyDelegate(int val);
    public void Run()
    {
      TestDelegate(1);
      // 2. delegate 변수에 반환형과 입력 parameter 형태가 일치하는 method 맵핑.
      MyDelegate md = new MyDelegate(TestDelegate);
      md(2);
    }

    private void TestDelegate(int val)
    {
      Console.WriteLine($"delegate val = {val}");
    }
  }
}
