// TimesTable.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_for1
{
  class TimesTable
  {
    // property 선언
    public int iBase { get; set; }

    // 생성자 생성의 우아함을 느낄 수 있다.
    public TimesTable(int iBase)
    {
      this.iBase = iBase;
    }

    public TimesTable() : this(2)
    {
    }

    // 구구단 계산 method
    public void printBase()
    {
      for (int i = 1; i < 10; i++)
        Console.WriteLine($"{iBase} * {i} = {iBase * i}");
    }
  }
}
