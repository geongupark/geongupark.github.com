// Program.cs
/*
 * 1. C# 1차원 배열의 사용법
 * 2. C# 2차원 배열의 사용법
 * 3. 사실 OOP에서는 class라는 존재가 있기 때문에 "class + 1차원 배열"로 모든 것을 표현할 수 있어요.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_8_1_Array
{
  class Program
  {
    static void Main(string[] args)
    {
      // 1. 1차원 배열 in C#
      int[] kor = new int[10];
      int[] math = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
      Console.WriteLine("kor[0] = " + kor[0]);

      // 2. 2차원 배열 in C#
      int[,] kor_2 = new int[10,10];
      int[,] math_2 = new int[,] { { 10, 20, 30 }, { 40, 50, 60 }, { 70, 80, 90 } };
    }
  }
}
