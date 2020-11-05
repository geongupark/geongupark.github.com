using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gus;

namespace _2_4_1_class_property
{
  class Program
  {
    static void Main(string[] args)
    {
      Student student = new Student();
      student.SetName("홍길동");
      Console.WriteLine(student.GetName());
      student.SetAge(125);
      student.Height = 170;
      Console.WriteLine("키 : "+student.Height);
    }
  }
}
