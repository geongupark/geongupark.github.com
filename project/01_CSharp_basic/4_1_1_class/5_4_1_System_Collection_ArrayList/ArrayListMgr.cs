// ArrayListMgr.cs
using System;
using System.Collections;
using System.Reflection;

namespace _5_4_1_System_Collection_ArrayList
{
  class ArrayListMgr
  {
    public void Run()
    {
      Boxing_UnBoxing();
      AboutArrayList();
      StudentClassSort();
    }
    private void Boxing_UnBoxing()
    {
      Console.WriteLine($"\n<< {MethodBase.GetCurrentMethod().Name} >>");
      int a = 3;
      object o = a; // boxing
      int b = (int)o; // unboxing
      Console.WriteLine($"boxing : {o}, unboxing : {b}");
    }
    private void AboutArrayList()
    {
      Console.WriteLine($"\n<< {MethodBase.GetCurrentMethod().Name} >>");
      ArrayList arrlist = new ArrayList();
      arrlist.Add(3);
      arrlist.Add("hi");
      foreach (object o in arrlist)
        Console.WriteLine($"{o}");
    }
    private void StudentClassSort()
    {
      Console.WriteLine($"\n<< {MethodBase.GetCurrentMethod().Name} >>");
      ArrayList al = new ArrayList { new Student("jin",1,10), new Student("gus", 1, 100), new Student("son",2,34), new Student("jung",1,24), new Student("ali",2,59) };

      Console.WriteLine($"\n<origin>");
      foreach (object o in al) { Console.WriteLine($"{o}"); }
      Console.WriteLine($"\n<Sort_Name>");
      al.Sort();
      foreach (object o in al) { Console.WriteLine($"{o}"); }
      Console.WriteLine($"\n<Sort_Score>");
      Student.SortStd = 1;
      al.Sort();
      foreach (object o in al) { Console.WriteLine($"{o}"); }
    }
  }
}
