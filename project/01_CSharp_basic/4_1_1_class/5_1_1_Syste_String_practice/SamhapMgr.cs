// SamhapMgr.cs
using System;
using System.Collections.Generic;

namespace _5_1_1_Syste_String_practice
{
  class SamhapMgr
  {
    public UserString MyUserString { get; set; }
    public SamhapMgr(string AllStr, List<string> SamList)
    {
      MyUserString = new UserString(AllStr, SamList);
    }
    public void Run()
    {
      for (; ; )
      {
        Console.WriteLine($"[삼합 검증 프로그램 V1.0] / {DateTime.Now.ToString("yyyyMMdd hh:mm:ss")}");
        MyUserString.PreCond();
        MyUserString.Execution();
        MyUserString.Result();
      }
    }
  }
}
