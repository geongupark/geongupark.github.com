// Student.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_1_class
{
  // Student는 Human, Animal class를 상속 받음.
  class Student : Human
  {
    public int Grade { get; set; }
    public int StudentClass { get; set; }
    public int StudentID { get; set; }

    public void Exam(){}
    public override void WhoAreYou()
    {
      Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name + "I'm a Student");
    }
    public override string ToString()
    {
      return $"{base.ToString()} : 등급 = {Grade}";
    }
  }
}
