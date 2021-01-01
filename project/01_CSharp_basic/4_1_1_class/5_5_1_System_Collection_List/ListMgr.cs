using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_5_1_System_Collection_List
{
  class ListMgr
  {
    public void Run()
    {
      Boxing_Unboxing();

    }
    private void Boxing_Unboxing()
    {
      ArrayList arrlist = new ArrayList();
      arrlist.Add(1);   // boxing 발생 함
      int a = (int)arrlist[0];  // unboxing 발생 함

      List<int> list = new List<int>();
      list.Add(1);  // boxing 발생 안 함
      a = list[0];  // unboxing 발생 안 함
    }
  }
}
