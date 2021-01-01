// genericMgr.cs
using _4_7_IEnumerable;
using System;
using System.Collections;
using System.Collections.Generic;

namespace _4_11_1_generic
{
  class genericMgr
  {
    public void Run1()
    {
      // 1. boxing & unboxing
      ArrayList list = new ArrayList();
      list.Add(4);
      list.Add("string");
      int a = (int)list[0]; // unboxing
      PrintMe(3);
      PrintMe("String");
    }
    public void Run2()
    {
      // 3. generic 사용법
      List<Student> list = new List<Student>();
      Student st1 = new Student("gg", 29);
      list.Add(st1);
    }

    public void Run3()
    {
      // 4. Generic class 만들어 쓰기
      PrintAny<int> p1 = new PrintAny<int>();
      p1.Print(3);
      PrintAny<double> p2 = new PrintAny<double>();
      p2.Print(3.14);

      // 5. Generic method 만들어 쓰기
      PrintAny1 p3 = new PrintAny1();
      p3.Print<int>(3);
      p3.Print(2);  // type 추정
    }

    // 2. 코드 중복
    private void PrintMe(int a)
    {
      System.Console.WriteLine($"{a}");
    }
    private void PrintMe(string a)
    {
      System.Console.WriteLine($"{a}");
    }

    // 4. Generic class 만들기
    // > compile time에 T가 사용한 자료형으로 치환 된다.
    class PrintAny<T>
    {
      public void Print(T val)
      {
        System.Console.WriteLine($"val = {val}");
      }
    }

    // 6. Generic class 활용
    // > Type 여러개 사용 가능
    // > where 조건을 통해 Type에 제약 걸 수 있음. 이를 통해 필요로 하는 기능 명시 가능. (T는 IComparable을 구현한 클래스로 제한 한다.)
    // > 이렇듯 Generic을 만들면 신경쓸게 여간 많은게 아니다. 그래서 잘 만들어 쓰질 않고 주로 만들어져 있는 것을 사용한다.
    class PrintAny2<T, U> where T : IComparable   // T는 IComparable을 구현한 클래스로 제한 한다.
    {
      public void Print(T val1, U val2)
      {
        System.Console.WriteLine($"val1 = {val1}, val2 = {val2}");
      }
    }

    // 5. Generic method만 만들어 쓰기
    class PrintAny1
    {
      public void Print<T>(T val)
      {
        System.Console.WriteLine($"val = {val}");
      }
    }

  }
}
