// NullableMgr.cs
using System;
using System.Collections.Generic;
using System.Reflection;

namespace _6_1_1_Nullable
{
  class NullableMgr
  {
    public void Run()
    {
      UseNullable();
      TandNullableT();
      isNull();
      NullCondition();
    }
    private void UseNullable()
    {
      Console.WriteLine($"\n<< {MethodBase.GetCurrentMethod().Name} >>");
      member mb = new member();
      Console.WriteLine($"bool : {mb.sex}, HasValue : {mb.sex != null}");
      Console.WriteLine($"bool with Nullable1 : {mb.sexWithNullable1}, HasValue : {mb.sexWithNullable1.HasValue}");
      Console.WriteLine($"bool with Nullable2 : {mb.sexWithNullable2}, HasValue : {mb.sexWithNullable2.HasValue}");
    }
    private void TandNullableT()
    {
      Console.WriteLine($"\n<< {MethodBase.GetCurrentMethod().Name} >>");
      int a = 10;
      int? b = a; // 얘는 그냥 대입 됨.
      a = b.Value;  // 얘는 그냥 대입 안됨.
    }
    private void isNull()
    {
      Console.WriteLine($"\n<< {MethodBase.GetCurrentMethod().Name}, NULL 병합 연산자 >>");
      string a = null;
      Console.WriteLine(a == null?"(null)":a);
      Console.WriteLine(a??"(null)");

      a = "gus";
      Console.WriteLine(a == null ? "(null)" : a);
      Console.WriteLine(a ?? "(null)");
    }
    private void NullCondition()
    {
      Console.WriteLine($"\n<< {MethodBase.GetCurrentMethod().Name}, NULL 조건 연산자 >>");
      List<int> list = null;

      int? ret = list?.Count;
      Console.WriteLine(ret == null? "(null)" : ret.ToString());  // null조건 연산자를 쓰지 않으면 try~catch 문을 써야함.
    }
  }
  class member
  {
    public bool sex { get; set; }
    public Nullable<bool> sexWithNullable1 { get; set; }
    public bool? sexWithNullable2 { get; set; }
  }
}
