using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_10_1_call_by_x_struct
{
  class Program
  {
    static void Main(string[] args)
    {
      // 1. Test of call by value
      int a = 1, b = 2;
      Console.WriteLine($"m1) a = {a}, b = {b}");
      int c = ValueTypeTest(a, b);
      Console.WriteLine($"m2) a = {a}, b = {b}");

      // 2. Test of call by reference
      student st1 = new student();
      st1.Age = 10;
      st1.ID = 20;
      Console.WriteLine($"m1) Age = {st1.Age}, ID = {st1.ID}");
      ReferenceTypeTest(st1);
      Console.WriteLine($"m2) Age = {st1.Age}, ID = {st1.ID}");
    }

    static int ValueTypeTest(int a, int b)
    {
      Console.WriteLine($"f1) a = {a}, b = {b}");
      a++;
      b++;
      Console.WriteLine($"f2) a = {a}, b = {b}");
      return a + b;
    }

    static void ReferenceTypeTest(student a)
    {
      Console.WriteLine($"f1) Age = {a.Age}, ID = {a.ID}");
      a.Age++;
      a.ID++;
      Console.WriteLine($"f2) Age = {a.Age}, ID = {a.ID}");
    }

    class student
    {
      public int Age { get; set; }
      public int ID { get; set; }
    }
  }
}
