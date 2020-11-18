// tableMgr.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_for1
{
  class tableMgr
  {
    internal void Run()
    {
      TimesTable tt = new TimesTable();
      for (int i = 2; i < 10; i++)
      {
        tt.iBase = i;
        tt.printBase();
        Console.WriteLine("----------------------------------");
      }
        
    }
  }
}
