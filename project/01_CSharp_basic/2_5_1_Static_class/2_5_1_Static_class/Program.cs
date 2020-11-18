/*
 * static class 배우기
1. static class인 Student class 선언
2. static class는 인스턴스 생성 불가능 함.
3. static class는 이렇게 사용함.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5_1_Static_class
{
  class Program
  {
    static void Main(string[] args)
    {
      // 2. static class는 인스턴스 생성 불가
      // Student stdent = new Student();

      // 3. static class 사용 방법
      Student.WhoAreYou();
    }
  }

  // 1. static class 선언
  static class Student
  {
    static public void WhoAreYou()
    {
      Console.WriteLine("나는 학생 클래스입니다.");
    }
  }
}
